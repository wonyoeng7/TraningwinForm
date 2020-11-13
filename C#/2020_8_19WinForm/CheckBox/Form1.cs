using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CheckBox

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string checkStates = "";

            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };


            //for (int iCount = 0; iCount < cBox.Length; iCount++)
            //{
            //    checkStates = cBox[iCount].Text + ":" + cBox[iCount].Checked + "\n";
            //}

            foreach (var item in cBox)
            {
                checkStates += string.Format("{0} : {1}\n",item.Text, item.Checked);
            }

            MessageBox.Show(checkStates, "체크박스 상태");
        }

    }
}
