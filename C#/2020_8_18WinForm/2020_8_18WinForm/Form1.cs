using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace _2020_8_18WinForm
{
    public partial class Form1 : Form
    {
        bool bButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (bButton == false)
            {
                FactButton.Text = "더블 클릭 당함";
                bButton = true;
            }
            else
            {
                FactButton.Text = "헬로키티 지옥으로";
                bButton = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = "마우스 올라옴";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "마우스 떠남";
        }

        private void FactButton_MouseMove(object sender, MouseEventArgs e)
        {
            FactButton.Text = "마우스 올라 옴";
        }

        private void FactButton_MouseLeave(object sender, EventArgs e)
        {
            FactButton.Text = "마우스 떠남";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {            
                textBox2.Text = textBox1.Text;
            }
        }

        private void FactButton_Click(object sender, EventArgs e)
        {

                textBox2.Text = textBox1.Text;

        }
    }
}
