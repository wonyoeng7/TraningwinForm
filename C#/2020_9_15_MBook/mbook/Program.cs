using MySql.Data.MySqlClient;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DataSet aDataSet = new DataSet();
        string Query = "SERVER=192.168.0.169;DATABASE=mydb;UID=root;PASSWORD=1234;";

        using (MySqlConnection aMySqlConnection = new MySqlConnection(Query))
        {
            Query = "SELECT * FROM tblRegisters";
            MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(Query, aMySqlConnection);
            aMySqlDataAdapter.Fill(aDataSet, "tblRegisters");
        }

            DataRow aDataRow;
            aDataRow = aDataSet.Tables["tblRegisters"].Rows[0];
            Console.WriteLine(aDataSet.Tables["tblRegisters"].Rows.Count);

        //    Console.WriteLine(aDataRow["name"] + ":" + aDataRow["num2"]);
        //}
    }
}
