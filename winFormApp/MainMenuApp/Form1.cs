using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();

        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TextBox.text += 새파일NToolStripMenuItem.text + Environment.NewLine;
            //실제 열기 로직
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TextBox.text += 새파일NToolStripMenuItem.text + Environment.NewLine;
            MessageBox.Show("저장했습니다.");
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //contextMenuStrip1.show(e.Location);
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            LblMouseLocation.Text = $"(X, Y) = ({e.X}, {e.Y})";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 대여관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
