using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonTestApp 
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnFlat_Click(object sender, EventArgs e)
        {
            LblButtonstlye.Text = FlatStyle.Flat.ToString();
        }

        private void BtnPopup_Click(object sender, EventArgs e)
        {
            LblButtonstlye.Text = FlatStyle.Popup.ToString();
        }

        private void BtnStanderd_Click(object sender, EventArgs e)
        {
            LblButtonstlye.Text = FlatStyle.Standard.ToString();
        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            LblButtonstlye.Text = FlatStyle.System.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LblButtonstlye.Text = "결과표시";
        }
    }
}
