using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int HumaniX;
        int HumaniY;
        int MoveUnit;
        const int iWidth = 50;
        const int iHeight = 50;
        const int iTileX = 16;
        const int iTileY = 10;
        Bitmap ImgGround;
       
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(iWidth * iTileX, iHeight * iTileY);
            HumaniX = 0;
            HumaniY = 0;
            MoveUnit = 50;
            ImgGround = new Bitmap(Properties.Resources.Gnd);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(ImgGround, HumaniX, HumaniY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    HumaniX += MoveUnit;
                    break;
                case Keys.Left:
                    HumaniX -= MoveUnit;
                    break;
                case Keys.Up:
                    HumaniY -= MoveUnit;
                    break;
                case Keys.Down:
                    HumaniY += MoveUnit;
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
