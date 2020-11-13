using System;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //텍스트 박스에 이름을 입력하지 않았을때
            {
                label2.Text = "";
                MessageBox.Show("이름을 입력하세요", "경고");
               
            }
            else 
            {
                label2.Text = textBox1.Text + "님 안녕하세요!";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
