using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception error)
            {
                MessageBox.Show("예외 발생");

            }
            
        }

            private void button2_Click(object sender, EventArgs e)
        {
            StreamReader R = new StreamReader(@"C:\factoty.txt");

            String readResult;

            while(true)
            {
                readResult = R.ReadLine();
                if(null == readResult)
                {
                    break;
                }
                MessageBox.Show(readResult);

            }

            
        }


        //    private void button3_Click(object sender, EventArgs e)
        //{

        //    //File.WriteAllText("C:\\factoty.txt", "factoty");
        //    //File.WriteAllText(@"C:\factoty.txt", "factoty");
        //    //string Temp = File.ReadAllText(@"C:\factoty.txt");
        //    //MessageBox.Show(Temp);
        //    //MessageBox.Show(File.ReadAllText(@"C:\factoty.txt"));
        //    int[] aint = new int[] {3, 6, 78, 20, 44 };

        //    StreamWriter W = new StreamWriter(@"C:\factoty.txt");
        //    W.WriteLine("지옥으로 키티");
        //    W.WriteLine("기다려 키티");
        //    W.WriteLine("쉬어야 해");
        //    foreach (var Temp in aint)
        //    {
        //        W.Write(Temp + ":");
        //    }
        //    W.Close();


        //}
    }
}
