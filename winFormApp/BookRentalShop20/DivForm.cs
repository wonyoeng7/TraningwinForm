using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class DivForm : MetroForm
    {

        string strConnString = "";
        string mode = "";

        public DivForm()
        {
            InitializeComponent();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void DivForm_Load(object sender, EventArgs e)
        {


            updateData();


        }

        private void updateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();//DB열기
                string strQuery = "SELECT Division, Names FROM divtbl";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl";
            }

            //throw new NotImplementedException();
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtDivision.ReadOnly = true;
                TxtDivision.BackColor = Color.SkyBlue;

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
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
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
            TxtDivision.Text = TxtDivision.Text = "";
            TxtDivision.ReadOnly = false;
            TxtDivision.BackColor = Color.White;

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
                    strQuery = " UPDATE dbo.divtbl " +
                               "    SET Names = @Names " +
                               "  WHERE Division = @Division ";

                }

                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.divtbl (Division,Names) VALUES (@Division, @Names)";

                }
                cmd.CommandText = strQuery;

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);    // DB에 저장된 스키마를 따라서
                parmDivision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);    // DB에 저장된 스키마를 따라서
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);

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
            if(string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
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
                parmDicision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDicision);

                cmd.ExecuteNonQuery();
            }
        }
    }
}