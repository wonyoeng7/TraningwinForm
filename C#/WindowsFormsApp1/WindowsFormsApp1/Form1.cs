using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int iX;
        int iY;
        const int iMoveUnit = 50;       //const는 상수로 만드는 작업이다.

        public Form1()
        {
            InitializeComponent();
            iX = 0;
            iY = 0;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap abitmap = new Bitmap(Properties.Resources._1);
            e.Graphics.DrawImage(abitmap, iX, iY);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Home:
                    iX = 0;
                    iY = 0;
                    break;
                case Keys.Right:
                    iX += iMoveUnit;
                    break;
                case Keys.Left:
                    iX -= iMoveUnit;
                    break;
                case Keys.Up:
                    iY -= iMoveUnit;
                    break;
                case Keys.Down:
                    iY += iMoveUnit;
                    break;
                default:
                    return; 

            }
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
