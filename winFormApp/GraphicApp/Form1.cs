using System.Drawing;
using System.Windows.Forms;

namespace GraphicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form1_Paint, 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">페인트이벤트아규먼트</param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();

            Pen pen = new Pen(Color.DeepPink);
            pen.Width = 6.8f;
            //point starpoint = new point(45, 45);
            //point endpoint = new point(180, 150);
            //g.drawline(pen, starpoint, endpoint);
            //g.drawline(pen, 190, 60,65,170);

            //Rectangle rect = new Rectangle(50, 50, 150, 100);
            Rectangle[] rects = new Rectangle[]
            {
                new Rectangle(40, 40, 40, 100),
                new Rectangle(100, 40, 100, 40),
                new Rectangle(100, 100, 100, 40),
            };
            g.FillRectangles(Brushes.BlueViolet,rects);
            g.DrawRectangles(pen,rects);

            Point[] pts =
            {
                new Point(515,30),new Point(540,90),
                new Point(600,115),new Point(540,140),
                new Point(515,200),new Point(490,140),
                new Point(430,115),new Point(490,90),

            };
            g.FillClosedCurve(Brushes.Yellow, pts);
            g.DrawClosedCurve(Pens.Red, pts);

            Font f = new Font("Tahoma", 15);
            g.DrawString("Hello World!", f, Brushes.Black, 10, 10);
            f.Dispose();


        }
    }
}
