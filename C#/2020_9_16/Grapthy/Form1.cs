using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        private static int DataSize = 300;
        private static string TName = "tblSensorDHT11";
        private static string QueryLogin = "SERVER=192.168.0.169; DATABASE=mydb; UID=root; PASSWORD=1234;";
        private static string QueryTable = "SELECT * FROM " + TName + " ORDER BY TIME DESC LIMIT";
        private static string QueryTable12 = QueryTable + DataSize.ToString();
        private static string QueryTable1 = QueryTable + 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet aDataSet = new DataSet();
            using (MySqlConnection aMySqlConnection = new MySqlConnection(QueryLogin))
            {
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(QueryTable, aMySqlConnection);
                aMySqlDataAdapter.Fill(aDataSet, TName);
            }

            List<int> TempData = new List<int>();
            List<int> HumiData = new List<int>();
            foreach (DataRow Temp in aDataSet.Tables[TName].Rows)
            {
                TempData.Add(Int32.Parse(Temp["TEMP"].ToString()));
                HumiData.Add(Int32.Parse(Temp["HUMI"].ToString()));
            }
            //MessageBox.Show(TempData.Count.ToString());

            chart1.Series[0].Points.DataBindY(TempData);
            chart1.Series[1].Points.DataBindY(HumiData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet aDataSet = new DataSet();
            using (MySqlConnection aMySqlConnection = new MySqlConnection(QueryLogin))
            {
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(QueryTable, aMySqlConnection);
                aMySqlDataAdapter.Fill(aDataSet, TName);
            }
            DataRow Temp = aDataSet.Tables[TName].Rows[0];
            chart1.Series[0].Points.Add(Int32.Parse(Temp["TEMP"].ToString()));
            chart1.Series[1].Points.Add(Int32.Parse(Temp["HUMI"].ToString()));

            if (chart1.Series[0].Points.Count > DataSize)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);

            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}