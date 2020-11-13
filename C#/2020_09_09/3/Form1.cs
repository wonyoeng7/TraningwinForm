using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            static void Main(string[] args)
            {
                XElement axElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
                var XMLData = from Temp in axElement.Descendants("data")
                              select new Weather
                              {
                                  Hour = Temp.Element("hour").Value,
                                  Temp = Temp.Element("temp").Value,
                                  Wfkor = Temp.Element("wfKor").Value,
                                  Wdkor = Temp.Element("wdKor").Value,

                              };

                foreach (var Temp in XMLData)
                {
                    Console.WriteLine(Temp);
                }

            }
        }
}
