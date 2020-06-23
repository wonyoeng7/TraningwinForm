using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MemberForm : MetroForm
    {

        string strConnString = "";
        string mode = "";

        public MemberForm()
        {
            InitializeComponent();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

     

        private void updateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();//DB열기
                string strQuery = "SELECT Idx,Names, Levels, Addr, Mobile, Email " +
                                  "FROM dbo.membertbl";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTbl.DataSource = ds;
                GrdMemberTbl.DataMember = "membertbl";

            }

            //throw new NotImplementedException();
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.SkyBlue;
                CboLeveis.SelectedIndex = CboLeveis.FindString(data.Cells[2].Value.ToString());
                TxtAddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();

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
            if (string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtNames.Text)
                || string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text))
            
         
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
            TxtIdx.Text = TxtNames.Text = TxtAddr.Text =TxtMobile.Text = TxtEmail.Text =  "";
            CboLeveis.SelectedIndex = -1;
            TxtAddr.ReadOnly = true;
            TxtAddr.BackColor = Color.White;
            TxtIdx.Focus();

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
                    strQuery = "UPDATE dbo.membertbl SET Names = @Names, Levels = @Levels, Addr = @Addr, Mobile = @Mobile, Email = @Email  WHERE Idx = @Idx"; 

                }

                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.membertbl(Names, Levels, Addr, Mobile, Email)" +
                        "VALUES(@Names, @Levels, @Addr, @Mobile, @Email)";

                }
                cmd.CommandText = strQuery;

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);   
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);

                SqlParameter parmLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                parmLevels.Value = CboLeveis.SelectedItem;
                cmd.Parameters.Add(parmLevels);

                SqlParameter parmAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);    
                parmAddr.Value = TxtAddr.Text;
                cmd.Parameters.Add(parmAddr);

                SqlParameter parmMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);   
                parmMobile.Value = TxtMobile.Text;
                cmd.Parameters.Add(parmMobile);

                SqlParameter parmEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);   
                parmEmail.Value = TxtEmail.Text;
                cmd.Parameters.Add(parmEmail);

              
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
            if(string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtMobile.Text))
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
                parmDicision.Value = TxtAddr.Text;
                cmd.Parameters.Add(parmDicision);

                cmd.ExecuteNonQuery();
            }
        }

        private void GrdMemberTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            updateData();   //데이터그리도 DB
        }
    }
}