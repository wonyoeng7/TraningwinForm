using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_09_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet aDataSet = new DataSet();   //DB에서 받아오는 그릇이다.
            using (MySqlConnection aMySqlConnection = new MySqlConnection(Query))
            {

                aMySqlConnection.Open();
                Query = "INSERT INTO tblRegisters(id, pwd, name, num1, num2, email, phone, zipcode, address, job) VALUES('oracle','7777','이순신','7777','787878','dsfa@dgegdf.com','010-7777-2222','74343','한국 어디저기77','프로그래머77');";
                MySqlCommand aMySqlCommand = new MySqlCommand(Query, aMySqlConnection);
                Console.WriteLine("쿼리 적용 " + ((aMySqlCommand.ExecuteNonQuery() == 1) ? "성공" : "실패"));

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
