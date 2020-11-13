using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        //int[] iPrice;
        //string[] sName;
        List<int> BookPrice = new List<int>();
        List<string> BookName = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //iPrice = new int[] { 12, 22, 32, 21,20,30 };
            //sName = new string[] { "철수", "영미", "원영", "하경", "동수", "짱구" };
            Book[] aBook = new Book[] 
                {new Book("책1",5000),
                 new Book("책2",2300),
                 new Book("책3",5300),
                 new Book("책4",1200),
                 new Book("책5",5900),
                 new Book("책6",9200)};
            foreach (var Temp in aBook)
            {
                BookPrice.Add(Temp.Price);
                BookName.Add(Temp.Name);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.DataBindY(iPrice);
            //chart1.Series[0].Points.DataBindX(sName);
            chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookName = textBox1.Name();
            BookPrice = (int)textBox2.Text.ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
