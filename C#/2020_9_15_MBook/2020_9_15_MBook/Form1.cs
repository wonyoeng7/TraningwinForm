using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_9_15_MBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=192.168.0.169;DATABASE=mydb;UID=root;PASSWORD=1234;"))
            {
                connection.Open(); //DB접속
                                   //Selected가 1이 된 부분만 출력
                string sql = "SELECT * FROM book";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "book");

                dataGridView1.DataSource = ds; //그리드의 데이터 소스에다가 붓는다.
                dataGridView1.DataMember = "book";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=192.168.0.169;DATABASE=mydb;UID=root;PASSWORD=1234;"))
            {
                connection.Open();
                string sql = "SELECT * FROM book";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader table = cmd.ExecuteReader();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }  
}
