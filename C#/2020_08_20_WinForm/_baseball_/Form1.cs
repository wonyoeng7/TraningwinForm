using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _baseball_
{
    public partial class Form1 : Form
    {
        int[] intArray;
        int Score;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            Random aRandom = new Random();
            intArray = new int[3] { 100, 100, 100 };

            for (int Count = 0; Count < intArray.Length; ++Count)
            {
                int iTemp = aRandom.Next(0, 10);


                int Count2;
                for (Count2 = 0; Count2 < intArray.Length; ++Count2)
                {
                    if (iTemp == intArray[Count2])
                    {

                        break;
                    }
                }
                if (Count2 < intArray.Length)
                {
                    --Count;
                    continue;
                }
                intArray[Count] = iTemp;
            }
            lbRand1.Text = intArray[0].ToString();
            lbRand2.Text = intArray[1].ToString();
            lbRand3.Text = intArray[2].ToString();

            Score = 0;
            lbCount.Text = Score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] intArray
            int[] inputArray = new int[intArray.Length];
            int StrikeCount = 0;
            int BallCount = 0;
            inputArray[0] = Convert.ToInt32(tbinput1.Text);
            inputArray[1] = Convert.ToInt32(tbinput2.Text);
            inputArray[2] = Convert.ToInt32(tbinput3.Text);

            for (int Count1 = 0; Count1 < intArray.Length; Count1++)
            {
                for (int Count2 = 0; Count2 < intArray.Length; Count2++)
                {
                    if (inputArray[Count1] == intArray[Count2])       //숫자 비교
                    {
                        if (Count1 == Count2)        //위치 비교
                        {
                            //MessageBox.Show("스트라이크");
                            ++StrikeCount;
                        }
                        else
                        {
                            //MessageBox.Show("볼");
                            ++BallCount;
                        }
                        break;
                    }
                }
            }
            lbStrike.Text = StrikeCount.ToString();
            lbBoll.Text = BallCount.ToString();

            //for (int Count2 = 0; Count2 < intArray.Length; Count2++)
            //{
            //    if (inputArray[1] == intArray[Count2])       //숫자 비교
            //    {
            //        if (0 == Count2)        //위치 비교
            //        {
            //            MessageBox.Show("스트라이크");
            //        }
            //        else
            //        {
            //            MessageBox.Show("볼");
            //        }
            //        break;
            //    }
            //}
            //for (int Count2 = 0; Count2 < intArray.Length; Count2++)
            //{
            //    if (inputArray[2] == intArray[Count2])       //숫자 비교
            //    {
            //        if (0 == Count2)        //위치 비교
            //        {
            //            MessageBox.Show("스트라이크");
            //        }
            //        else
            //        {
            //            MessageBox.Show("볼");
            //        }
            //        break;
            //    }
            //}
            //if(inputArray[0] == intArray[0])
            //{
            //    MessageBox.Show("스트라이크");
            //}

            //if (inputArray[0] == intArray[1])
            //{
            //    MessageBox.Show("볼");
            //}

            //if (inputArray[0] == intArray[2])
            //{
            //    MessageBox.Show("볼");
            //}


            //일단 노가다 코드를 작성후 그다음에 for문이나 코드를 줄일걸 생각하는거다.

            ++Score;
            lbCount.Text = Score.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            lbStrike.Text = "0";
            lbBoll.Text = "0";
            tbinput1.Clear();
            tbinput2.Clear();
            tbinput3.Clear();

        }
    }
}
