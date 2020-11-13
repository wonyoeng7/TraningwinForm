using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPcap;    //C#용 Packet Capture

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SharpPcap.Version.VersionString);
            CaptureDeviceList NicList = CaptureDeviceList.Instance;
            //MessageBox.Show(NicList.Count.ToString());

            string NicListResult = "";



            foreach (var Temp in NicList)
            {
                //string Temp2 = Temp.ToString().Substring(Temp.ToString().IndexOf("FriendlyName") + "FriendlyName".Length, 10);
                //NicListResult += (Temp2 + "\n");

                string[] arrTemp = Temp.ToString().Split('\n');
                arrTemp[1].Substring("FriendlyName: ".Length);

                NicListResult += (arrTemp[1].Substring("FriendlyName: ".Length) + "\n");

            }
            Button aButton1 = new Button();
            aButton1.Text = "button2";
            aButton1.Name = "button2";
            Controls.Add(aButton1);

            MessageBox.Show(NicListResult);
        }
    }
}
