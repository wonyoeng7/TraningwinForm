using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_10_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader(@"C:\1.text");    //읽어들일 TXT 파일의 경로를 
                                                                    //매개변수로 StreamReader 생성

            string line;                                            //한 줄씩 읽은 후, 그 값을 저장시킬 변수

            string result = "";                                     //전체 라인을 저장시킬 변수
            while ((line = SR.ReadLine()) != null)                  //line변수에 SR에서 한줄을 읽은 걸 저장, 읽은 줄이 null이 아닐때까지 반복
            {
                result += line;                                      //전체 라인 변수에 그 값을 저장
                result += "\r\n";                                   //표출을 위해서 추가
            }
            textBox1.Text = result;                                 //예제 textbox폼에 전체 읽은 문구를 표출
            SR.Close();                                              //StreamReader를 닫아줌



        }
    }
}
