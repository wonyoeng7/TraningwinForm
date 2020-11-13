using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader R = new StreamReader(@"C:\factoty.txt");
            while(true)
            {
                string rName = R.ReadLine();
                if(null == rName)
                {
                    break;
                }
                string rPrice = R.ReadLine();

                productBindingSource.Add(new Product() { Name = rName, Price = Convert.ToInt32(rPrice) });
            }

            //productBindingSource.Add(new Product() { Name = "고메", Price = 1200 });
            //productBindingSource.Add(new Product() { Name = "맛고메", Price = 1300 });
            //productBindingSource.Add(new Product() { Name = "소고메", Price = 1100 });
            //productBindingSource.Add(new Product() { Name = "다고메", Price = 1500 });
            //productBindingSource.Add(new Product() { Name = "모고메", Price = 1800 });
        }

    }
}
