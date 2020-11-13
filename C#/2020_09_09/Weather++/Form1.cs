using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Weather__
{
    public partial class Form1 : Form
    {
        List<string> Temp = new List<string>();
        List<string> Hour = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XElement axElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            var XMLData = from Temp in axElement.Descendants("data")
                          select new Weather()
                          {
                              Hour = Temp.Element("hour").Value,
                              Temp = Temp.Element("temp").Value,
                              Wfkor = Temp.Element("wfKor").Value,
                              Wdkor = Temp.Element("wdKor").Value,

                          };
            foreach (var item in XMLData)
            {
                Console.WriteLine(Temp);
                Temp.Add(item.Temp);
                Hour.Add(item.Hour);
            }

            chart1.Series[0].Points.DataBindY(Temp);
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsValueShownAsLabel = true;

            chart1.Series[1].Points.DataBindY(Hour);
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].IsValueShownAsLabel = true;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
