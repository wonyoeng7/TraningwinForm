using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Timer_
{
    public partial class Form1 : Form
    {
        private int CountMS = 0;       //var는 지역변수에만 사용가능 클래스 변수에는 사용불가
        private int CountM = 0;
        private int CountS = 0;

        private bool Toggle = false;


        public  Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++CountMS;
            if(CountMS == 100)
            {
                CountMS = 0;
                ++CountS;
                
                if (CountS == 60)
                {
                    CountS = 0;
                    ++CountM;                  
                }                
            }
        }

        private void timer2_Tick(object sender, EventArgs e) 
        {
            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Toggle == false)
            {
                timer1.Start();
                timer2.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Toggle = false;

            CountMS = 0;
            CountM = 0;
            CountS = 0;

            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();

        }
    }
}
