using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_10_15
{
    public partial class Form1 : Form
    {
        int iX;
        int iY;
        public Form1()
        {
            InitializeComponent();
            iX = 0;
            iY = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //그래픽스 객체
            //Graphics g = CreateGraphics();

            //비트맵 로드
            //Bitmap abitmap = new Bitmap(@"C:\Users\admin\Desktop\1.bmp");
            Bitmap abitmap1 = new Bitmap(Properties.Resources._1);
            Bitmap abitmap2 = new Bitmap(Properties.Resources.Image1);
            //비트맵 그리기
            e.Graphics.DrawImage(abitmap1,iX,iY);

            


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ++iX;
            ++iY;
            this.Invalidate();  
        }
    }
}
