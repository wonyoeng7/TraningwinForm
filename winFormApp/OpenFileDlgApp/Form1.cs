using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDlgApp
{
    public partial class Form1 : Form
    {
        public object ColorDialog1 { get; private set; }

        public Form1() => InitializeComponent();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory= "C:\\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();

            foreach (var item in openFileDialog1.FileName)
            {
                textBox1.Text += item;
                textBox1.Text += Environment.NewLine;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(ColorDialog.showDialog() == DialogResult.OK)
            {
                BackColor = ColorDialog1.Color  

            }
        }
    }
}
