using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class UserForm : MetroForm
    {

        string strConnString = "Data Source=192.168.0.17;Initial Catalog=BOOKRENTALSHOPDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";

        public UserForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            updateData();
        }
        /// <summary>
        /// 사용자 데이터 가져오기
        /// </summary>
        private void updateData()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();//DB열기
                string strQuery = "SELECT id,userID,password,lastLoginDt,loginIpAddr FROM dbo.userTbl";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl");

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "userTbl";
            }

            DataGridViewColumn column = GrdUserTbl.Columns[0];  //id 컬럼
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdUserTbl.Columns[1];
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2];
            column.Width = 200;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3];
            column.Width = 120;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4];
            column.Width = 150;
            column.HeaderText = "접속아이디주소";




            //throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// 그리드 셀클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                TxtId.Text = data.Cells[0].Value.ToString();
                TxtuserID.Text = data.Cells[1].Value.ToString();
                TxtPassword.Text = data.Cells[2].Value.ToString();
               
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
            if (string.IsNullOrEmpty(TxtuserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveProcess();
            updateData();   //이미 수정

            clearTextControls();


            // DB 저장 Process

        }

        private void clearTextControls()
        {
            TxtId.Text = TxtuserID.Text = TxtuserID.Text = "";
           //TxtuserID.ReadOnly = false;
           //TxtuserID.BackColor = Color.White;

        }

        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //DB저장프로세스
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.userTbl SET UserID = @UserID, Password = @Password, WHERE ID = @ID";

                }

                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.userTbl (UserID, password) VALUES(@UserID, @Password)";

                }
                cmd.CommandText = strQuery;

                SqlParameter parmUserID = new SqlParameter("@UserID", SqlDbType.VarChar, 12);    // DB에 저장된 스키마를 따라서
                parmUserID.Value = TxtuserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmPassword = new SqlParameter("@Password", SqlDbType.VarChar, 20);    // DB에 저장된 스키마를 따라서
                parmPassword.Value = TxtPassword.Text;
                cmd.Parameters.Add(parmPassword);

                if (mode == "UPDATE")
                {
                    SqlParameter parmID = new SqlParameter("@ID", SqlDbType.Int);    // DB에 저장된 스키마를 따라서
                    parmID.Value = TxtId.Text;
                    cmd.Parameters.Add(parmID);
                }

                cmd.ExecuteNonQuery();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtuserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
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
            using (SqlConnection Conn = new SqlConnection(strConnString))
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDicision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDicision.Value = TxtuserID.Text;
                cmd.Parameters.Add(parmDicision);

                cmd.ExecuteNonQuery();
            }
        }
    }
}