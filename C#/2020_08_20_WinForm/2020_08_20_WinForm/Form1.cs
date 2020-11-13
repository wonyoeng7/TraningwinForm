using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_08_20_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;

            str = label1.Text + " : " + maskedTextBox1.Text + "\n";
            str += label2.Text + " : " + maskedTextBox2.Text + "\n";
            str += label3.Text + " : " + maskedTextBox3.Text + "\n";
            str += label4.Text + " : " + maskedTextBox4.Text + "\n";
            str += label5.Text + " : " + maskedTextBox5.Text + "\n";
            str += label6.Text + " : " + maskedTextBox6.Text + "\n";

            MessageBox.Show(str, "개인정보");
        }

     
    }
}
