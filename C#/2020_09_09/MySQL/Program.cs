using MySql.Data.MySqlClient;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DataSet aDataSet = new DataSet();   //DB에서 받아오는 그릇이다.
        string Query = "SERVER=192.168.0.169;DATABASE=mydb;UID=root;PASSWORD=1234;";    // 쿼리문을 날린다.

        //using (MySqlConnection aMySqlConnection = new MySqlConnection(Query))   //using문을 사용하면 간단하다.
        //{
        //    Query = "SELECT * FROM tblRegisters";
        //    MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(Query, aMySqlConnection);
        //    aMySqlDataAdapter.Fill(aDataSet, "tblRegisters");
        //}
        using (MySqlConnection aMySqlConnection = new MySqlConnection(Query))
        {

            aMySqlConnection.Open();
            Query = "INSERT INTO tblRegisters(id, pwd, name, num1, num2, email, phone, zipcode, address, job) VALUES('oracle','7777','이순신','7777','787878','dsfa@dgegdf.com','010-7777-2222','74343','한국 어디저기77','프로그래머77');";
            MySqlCommand aMySqlCommand = new MySqlCommand(Query, aMySqlConnection);
            Console.WriteLine("쿼리 적용 " + ((aMySqlCommand.ExecuteNonQuery() == 1) ? "성공" : "실패"));

        }



        //DataRow aDataRow;

        //aDataRow = aDataSet.Tables["tblRegisters"].Rows[0];
        //Console.WriteLine(aDataSet.Tables["tblRegisters"].Rows.Count);
        //string Temp = (string)aDataRow["name"]; //"name"이랑 배열 2를 넣어도 똑같다. 
        //Console.WriteLine(Temp);
        //Console.WriteLine(aDataRow["name"] + ":" + aDataRow["num2"]);
        //Console.WriteLine(aDataRow["name"] + ":" + aDataRow["num2"]);


       
        //string insertQuery = "INSERT INTO tblRegisters(id,pwd,name,num1,num2,email,phone,zipcode,address,job) VALUES(test,1234,홍길동,12345,12345,wonyoeng7@naver.com,010-4562-2923,1234,부산시 북구,백수)";
        //using (MySqlConnection aMySqlConnection = new MySqlConnection(insertQuery))   //using문을 사용하면 간단하다.
        //{
        //    insertQuery = "SELECT * FROM tblRegisters";
        //    MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(insertQuery, aMySqlConnection);
        //    aMySqlDataAdapter.Fill(aDataSet, "tblRegisters");
        //}

    }
}