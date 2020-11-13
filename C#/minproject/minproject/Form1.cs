using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minproject
{
    public partial class Form1 : Form
    {
        bool LineStatus;

        public Form1()      //생성자
        {
            InitializeComponent();
            LineStatus = false;
        }
        public void DrawLinePointF(PaintEventArgs e)
        {
           
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(LineStatus == true)
            {
                Pen BurlyWoodPen = new Pen(Color.BurlyWood, 3);
                PointF point1 = new PointF(100.0F, 100.0F);
                PointF point2 = new PointF(500.0F, 100.0F);
                Graphics g = CreateGraphics();
                g.DrawLine(BurlyWoodPen, point1, point2);
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)     
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineStatus = true;
            /*
            var bitmap = new Bitmap(@"d:/1.bmp");
            Graphics g = CreateGraphics();
            g.DrawImage(bitmap, 0, 0);
            */
            Pen BurlyWoodPen = new Pen(Color.BurlyWood, 3);
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);
            Graphics g = CreateGraphics();
            g.DrawLine(BurlyWoodPen, point1, point2);

            Graphics g1 = CreateGraphics();
            Bitmap abitmap = new Bitmap(@"C:\Users\admin\Desktop\1.bmp");
            g1.DrawImage(abitmap, 10, 10);
        }

        void TestLine()
        {
            Graphics g = CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);
            g.DrawLine(blackPen, point1, point2);
        }
    }
}
