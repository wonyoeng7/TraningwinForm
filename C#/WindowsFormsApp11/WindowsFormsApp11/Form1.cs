using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string Message = "ABCDEF";
        private void Form1_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show(Message.Substring(0,1));
            MessageBox.Show(string.Format("{0}", 'A'));
            MessageBox.Show(string.Format("{0}", 'B'));
            MessageBox.Show(string.Format("{0}", 'C'));
            MessageBox.Show(string.Format("{0}", 'D'));
            */
            for (int i = 0; i < Message.Length; i++)
            {
               MessageBox.Show(string.Format("{0}", Message[i]));
            }
            
            foreach (var item in Message)
            {
                MessageBox.Show(string.Format("{0}", item));
            }

            
                

            

            
        }
    }
}

//메소드 ()가 있다.
