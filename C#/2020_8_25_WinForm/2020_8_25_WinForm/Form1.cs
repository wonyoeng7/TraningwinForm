using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_8_25_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> aList = new List<Product>() {
                new Product(){Name ="고메",Price = 1200 },
                new Product(){Name ="맛고메1",Price = 1300 },
                new Product(){Name ="소고메2",Price = 1100 },
                new Product(){Name ="다고메3",Price = 1500 },

            };

            //aList.Sort();
            string result = "";
            foreach (var Temp in aList)
            {
                result += (Temp +"\n" );
            }
            MessageBox.Show(result);
        }
    }
}
