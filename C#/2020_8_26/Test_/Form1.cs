using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Oracle_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConn = "Data Source=(DESCRIPTION="              // C#
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.35.249)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
                + "User Id=HR;Password=1234;";
            using (OracleConnection conn = new OracleConnection(strConn))
            {
                conn.Open();


                string strQuery = "SELECT * FROM JOBS";
                OracleDataAdapter dataAdapter = new OracleDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "JOBS");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "JOBS";

                conn.Close();
            }
        }
    }
}