using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ScrollBar_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            textR.Text = 0.ToString();
            textG.Text = 0.ToString();
            textB.Text = 0.ToString();

            scrR.Maximum = 255 + 9;
            scrG.Maximum = 255 + 9;
            scrB.Maximum = 255 + 9;


        }

        private void srcR_Scroll(object sender, ScrollEventArgs e)
        {
            textR.Text = scrR.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
        }

        private void srcG_Scroll(object sender, ScrollEventArgs e)
        {
            textG.Text = scrG.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
        }

        private void srcB_Scroll(object sender, ScrollEventArgs e)
        {
            textB.Text = scrB.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
        }

        private void textR_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
