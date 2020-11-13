using System;
using System.Windows.Forms;

namespace check_box123
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

            foreach (CheckBox item in cBox)
            {
                checkStates += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }

            MessageBox.Show(checkStates, "체크박스 상태");

            string summary = string.Format("좋아하는 과일은:");
            foreach(var item in cBox)
            {
                if (item.Checked == true)
                    summary += item.Text + " ";
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
