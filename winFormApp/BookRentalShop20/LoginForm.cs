using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class LoginForm : MetroForm
    {
        string strConnString = "Data Source=192.168.0.17;Initial Catalog=BOOKRENTALSHOPDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 캔슬버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCacel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }
        /// <summary>
        /// 로그인 처리 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)    //
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginProcess();
            }
        }

        private void LoginProcess()
        {
            //throw new NotImplementedException();
            if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요|", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strUerID = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM userTbl " + "WHERE userID = @userID " + "AND password = @password";

                    SqlParameter parmuserID = new SqlParameter("@userID", System.Data.SqlDbType.VarChar, 12);
                    parmuserID.Value = TxtUserID.Text;
                    cmd.Parameters.Add(parmuserID);

                    SqlParameter parmPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar, 20);
                    parmPassword.Value = TxtPassword.Text;
                    cmd.Parameters.Add(parmPassword);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUerID = reader["userID"].ToString() != null ? reader["userID"].ToString() : "";

                    if (strUerID != "")
                    {
                        MetroMessageBox.Show(this, "접속성공", "로그인 성공");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //Debug.WriteLine("On the Debug");

                }

            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this,$"Error : {ex.StackTrace}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;               
            }
            
            
        }
    }
}
