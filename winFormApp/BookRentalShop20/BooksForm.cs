using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class BooksForm : MetroForm
    {

        string strConnString = "";
        string mode = "";

        public BooksForm()
        {
            InitializeComponent();
        }

        private void updateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();//DB열기
                string strQuery = "SELECT b.Idx,b.Author,b.Division,d.Names as'DivNames', b.Names, " +
                                  "b.ReleaseDate,b.ISBN , " +
                                  "REPLACE(CONVERT(VARCHAR, CONVERT(MONEY, b.Price), 1), '.00', '') AS price " +
                                  "FROM dbo.bookstbl AS b " +
                                  "INNER JOIN dbo.divtbl as d " +
                                  "on b.Division = d.Division ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "bookstbl");

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = "bookstbl";

            }
            DataGridViewColumn column = GrdBooksTbl.Columns[2];  //id 컬럼
            column.Visible = false;

            //throw new NotImplementedException();
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtAuthor.Text = data.Cells[1].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.SkyBlue;
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[2].Value.ToString());
                CboDivision.SelectedValue = data.Cells[2].Value;
                TxtNames.Text = data.Cells[4].Value.ToString();

                DtpReleaseDate.CustomFormat = "yyyy-mm-dd";
                DtpReleaseDate.Format = DateTimePickerFormat.Custom;

                DtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                TxtISBN.Text = data.Cells[6].Value.ToString();
                TxtPrice.Text = data.Cells[7].Value.ToString();

                mode = "UPDATE";


            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            clearTextControls();

            mode = "INSERT";    //신규는 INSERT


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtAuthor.Text)
                 || string.IsNullOrEmpty(TxtISBN.Text)) //나머지 컨트롤도 검사해야 한다.
            
         
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveProcess();
            updateData();

            clearTextControls();


            // DB 저장 Process

        }

        private void clearTextControls()
        {
            TxtIdx.Text = TxtAuthor.Text = TxtNames.Text =  TxtISBN.Text =  "";
            TxtPrice.Text = "";
            CboDivision.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.White;

            DtpReleaseDate.CustomFormat = " ";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;

            TxtAuthor.Focus();

        }

        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.bookstbl SET Author = @Author, Division = @Division, Names = @Names, ReleaseDate = @ReleaseDate, ISBN = @ISBN, Price = @Price WHERE Idx = @Idx "; 

                }

                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.bookstbl(Author, Division, Names, ReleaseDate, ISBN, Price) " +
                               "VALUES(@Author, @Division, @Names, @ReleaseDate, @ISBN , @Price)";

                }
                cmd.CommandText = strQuery;

                SqlParameter parmAuthor = new SqlParameter("@Author", SqlDbType.VarChar, 45);
                parmAuthor.Value = TxtAuthor.Text;
                cmd.Parameters.Add(parmAuthor);

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = CboDivision.SelectedValue;
                cmd.Parameters.Add(parmDivision);

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 100);
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);
              
                SqlParameter parmReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                parmReleaseDate.Value = DtpReleaseDate.Value;
                cmd.Parameters.Add(parmReleaseDate);

                SqlParameter parmISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                parmISBN.Value = TxtISBN.Text;
                cmd.Parameters.Add(parmISBN);

                SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Decimal, 10);
                parmPrice.Value = TxtPrice.Text;
                cmd.Parameters.Add(parmPrice);

                if (mode == "UPDATE")
                {
                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);
                }

                cmd.ExecuteNonQuery();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtNames.Text) )
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProcess();
            updateData();

            clearTextControls();
        }
       

        private void DeleteProcess()
        {
            using (SqlConnection Conn = new SqlConnection(Commons.CONNSTRING))
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDicision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDicision.Value = TxtNames.Text;
                cmd.Parameters.Add(parmDicision);

                cmd.ExecuteNonQuery();
            }
        }

        private void GrdMemberTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

            DtpReleaseDate.CustomFormat = "yyyy-mm-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;

            updateData();   //데이터그리도 DB데이터 로딩하기
            UpdateCboDivision();

        }

        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(); ;
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM divtbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while( reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;





            }
        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-mm-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }
    }
}
