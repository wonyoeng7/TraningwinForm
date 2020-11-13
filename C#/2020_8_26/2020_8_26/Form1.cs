using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;

namespace _2020_8_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Size = new Size(600, 650);
        }


        private void button1_Click2(object sender, EventArgs e)
        {
            string NicListResult = ""; // NIC : Network Interface Card
            List<string> NicName = new List<string>();
            foreach (ICaptureDevice Temp in CaptureDeviceList.Instance)
            {
                string[] arrTemp = Temp.ToString().Split('\n');
                NicName.Add(arrTemp[1].Substring("FriendlyName: ".Length));
            }

            for (int iTemp = 0; iTemp < NicName.Count; ++iTemp)
            {
                Button aButton = new Button();
                aButton.Text = NicName[iTemp];      //Ul의 나타는 글자를 나타낸다.
                aButton.Name = "Facto" + iTemp;     //그 차제의 이름을 나타낸다.
                aButton.Location = new Point(30, 30 + iTemp * 50);    //point는 위치 확인을 위해서 
                aButton.Click += new EventHandler(Facto_Click);
                Controls.Add(aButton);
            }

            (sender as Button).Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 변수 선언
            int XMargin = 10;
            int XSize = 120;
            int XInterval = 10;
            int YMargin = 15;
            int YSize = 20;
            int YInterval = 10;

            // Data 입력
            int Port1 = BitConverter.ToInt16(Data.skip<byte>(34).take(2).Reverse().ToArray(), 0);
            int Port2 = BitConverter.ToInt16(Data.skip<byte>(36).take(2).Reverse().ToArray(), 0);
            int Port1 = (Por1 < Por2) ? Port1 : Port2;
            Port1 = (Port1 < 1024) ? Port1 : 0;
            switch()
            {
                case 7: UdpClient ECHO "프로토콜";
                    break;
                

            }
            List<FactoLabel> aFactoLabel = new List<FactoLabel>();

            int iNum = BitConverter.ToInt16(DataBindings.skip<byte>(34).Take(2))
            int iNum = BitConverter.ToUInt16(Data.Skip<byte>(32).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Source Port", Value = "value1" });
            iNum = BitConverter.ToInt16(Data.skip<byte>(34),Take
            aFactoLabel.Add(new FactoLabel() { Name = "Destination Port", Value = "value2" });
            aFactoLabel.Add(new FactoLabel() { Name = "Test3", Value = "value3" });
            aFactoLabel.Add(new FactoLabel() { Name = "Test4", Value = "value4" });
            aFactoLabel.Add(new FactoLabel() { Name = "Test5", Value = "value5" });
            aFactoLabel.Add(new FactoLabel() { Name = "Test6", Value = "value6" });
            aFactoLabel.Add(new FactoLabel() { Name = "Test7", Value = "value7" });


            // 그룹박스 설정
            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(315, 22);
            aGroupBox.Name = "GroupTCP";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInterval, (YInterval + YSize) * aFactoLabel.Count + YMargin);
            aGroupBox.Text = "TCP Layer";

            // 라벨 설정
            for (int Count = 0; Count < aFactoLabel.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Name;
                aLabel.Name = "****";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Value;
                aLabel.Name = "****1";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin + XSize + XInterval, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);
            }



            // 그룹박스 출력
            Controls.Add(aGroupBox);
        }

        private void Print_TCP(byte[] Data)
        {
            // 변수 선언
            int XMargin = 10;
            int XSize = 120;
            int XInterval = 10;
            int YMargin = 15;
            int YSize = 20;
            int YInterval = 10;

            // Data 입력           
            List<FactoLabel> aFactoLabel = new List<FactoLabel>();

            UInt32 iNum = BitConverter.ToUInt16(Data.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Source Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(36).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Destination Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(Data.Skip<byte>(38).Take(4).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Sequence Number", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(Data.Skip<byte>(42).Take(4).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Ack Number", Value = iNum.ToString() });

            iNum = (UInt32)((Data[46] >> 4) * 4);
            aFactoLabel.Add(new FactoLabel() { Name = "Offset", Value = iNum.ToString() });

            iNum = Data[47];
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Urgent", Value = (0 != (iNum & 1 << 5)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Ack", Value = (0 != (iNum & 1 << 4)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Push", Value = (0 != (iNum & 1 << 3)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Res", Value = (0 != (iNum & 1 << 2)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Syn", Value = (0 != (iNum & 1 << 1)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Fin", Value = (0 != (iNum & 1 << 0)).ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(48).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Windows Size", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(50).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Checksum", Value = string.Format("0x{0:X4}", iNum) });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(52).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Urgent Pointer", Value = string.Format("0x{0:X4}", iNum) });

            // 그룹박스 설정
            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(315, 22);
            aGroupBox.Name = "GroupTCP";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInterval, (YInterval + YSize) * aFactoLabel.Count + YMargin);
            aGroupBox.Text = "TCP Layer";

            // 라벨 설정
            for (int Count = 0; Count < aFactoLabel.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Name;
                aLabel.Name = "****";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Value;
                aLabel.Name = "****1";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin + XSize + XInterval, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);
            }



            // 그룹박스 출력
            Controls.Add(aGroupBox);
        }
        private void Print_MAC(byte[] EtherData)
        {
            Label aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Destination MAC";
            aLabel.Name = "LabelDMAC";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 30);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Source MAC";
            aLabel.Name = "LabelSMAC";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 60);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Next Protocol";
            aLabel.Name = "LabelProto";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 90);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            string data = string.Format("{0:X2}", EtherData[0]);
            for (int iTemp = 1; iTemp < 6; ++iTemp)
            {
                data += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = data;
            aLabel.Name = "LabelDMACData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 30);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            data = string.Format("{0:X2}", EtherData[6]);
            for (int iTemp = 7; iTemp < 12; ++iTemp)
            {
                data += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = data;
            aLabel.Name = "LabelSMACData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 60);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;




            int iNum = BitConverter.ToInt16(EtherData.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);

            switch (iNum)
            {
                case 0x0800:
                    data = "IP";
                    break;

                case 0x0200:
                    data = "Xerox PUP";
                    break;

                case 0x0500:
                    data = "Sprite";
                    break;

                case 0x0806:
                    data = "Address resolution";
                    break;

                case 0x8035:
                    data = "Reverse ARP";
                    break;

                case 0x8100:
                    data = "IEEE 802.1Q VLAN tagging";
                    break;

                case 0x8137:
                    data = "IPX";
                    break;

                case 0x86dd:
                    data = "IP protocol version 6";
                    break;

                case 0x9000:
                    data = "used to test interfaces";
                    break;

                default:
                    data = "Unknown";
                    break;

            }

            aLabel.Text = data;
            aLabel.Name = "LabelProtoData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 90);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);
        }

        private int Del_Button_Device(object sender)
        {
            MessageBox.Show((sender as Button).Name.Substring("Facto".Length));
            //CaptureDeviceList.Instance[2];
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));         //오픈
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);       //오픈
            for (int iTemp = 0; iTemp < CaptureDeviceList.Instance.Count; ++iTemp)
            {
                foreach (Control Temp in Controls)
                {
                    if ("Facto0" == Temp.Name)
                    {
                        Controls.Remove(Temp);
                    }

                }

            }
            return DeviceNum;
        }

        private void Print_IP(byte[] IPData)
        {
            Label aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP version";
            aLabel.Name = "LabelIP";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 120);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Head Length";
            aLabel.Name = "LabelPHL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 150);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP TOS";
            aLabel.Name = "LabelIPTOS";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 180);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Total Length";
            aLabel.Name = "LabelIPTL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 210);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Identification";
            aLabel.Name = "LabelIPID";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 240);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Fragment DF";
            aLabel.Name = "LabelIPFDF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 270);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Fragment MF";
            aLabel.Name = "LabelIPFMF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 290);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Fragment Offset";
            aLabel.Name = "LabelIPFO";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 310);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Time To Live";
            aLabel.Name = "LabelIPTTL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 330);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "L3 Protocol";
            aLabel.Name = "LabelIPP";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 350);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Header Checksum";
            aLabel.Name = "LabelCHK";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 370);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Source Address";
            aLabel.Name = "LabelSA";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 390);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Destination Address";
            aLabel.Name = "LabelDA";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(30, 410);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);


            byte byteTemp = IPData[14];


            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IPv" + (byteTemp >> 4).ToString();
            aLabel.Name = "LabelIPVData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 120);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = ((byteTemp & 0x0f) * 4).ToString() + " Bytes";
            aLabel.Name = "LabelPHLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 150);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byteTemp = IPData[15];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = string.Format("0x{0:X2}", byteTemp);
            aLabel.Name = "LabelIPTOSData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 180);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            int iNum = BitConverter.ToUInt16(IPData.Skip<byte>(16).Take(2).Reverse<byte>().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = iNum.ToString() + " Byte";
            aLabel.Name = "LabelIPTLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 210);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(18).Take(2).Reverse<byte>().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = iNum.ToString();
            aLabel.Name = "LabelIPIDData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 240);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);


            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(20).Take(2).Reverse().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = (0 != (iNum & (1 << 14))).ToString();
            aLabel.Name = "LabelIFDFData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 270);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = (0 != (iNum & (1 << 13))).ToString();
            aLabel.Name = "LabelIPFMFData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 290);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = (iNum & 0x1FFF).ToString();
            aLabel.Name = "LabelIPFOData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 310);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byteTemp = IPData[22];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = byteTemp.ToString();
            aLabel.Name = "LabelIPTTLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 330);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            byteTemp = IPData[23];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;

            switch (byteTemp)
            {
                case 0:
                    aLabel.Text = "IP";
                    break;
                case 1:
                    aLabel.Text = "ICMP";
                    break;
                case 2:
                    aLabel.Text = "IGMP";
                    break;
                case 4:
                    aLabel.Text = "IPIP";
                    break;
                case 6:
                    aLabel.Text = "TCP";
                    break;
                case 8:
                    aLabel.Text = "EGP";
                    break;
                case 12:
                    aLabel.Text = "PUP";
                    break;
                case 17:
                    aLabel.Text = "UDP";
                    break;
                case 22:
                    aLabel.Text = "IDP";
                    break;
                case 29:
                    aLabel.Text = "TP";
                    break;
                case 33:
                    aLabel.Text = "DCCP";
                    break;
                case 41:
                    aLabel.Text = "IPV6";
                    break;
                default:
                    break;

            }
            aLabel.Name = "LabelIPPData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 350);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(24).Take(2).Reverse().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = string.Format("0x{0:X4}", iNum);
            aLabel.Name = "LabelIPPData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 370);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            IPAddress aIPAddress = new IPAddress(IPData.Skip<byte>(26).Take(4).ToArray());

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = aIPAddress.ToString();
            aLabel.Name = "LabelIPSAData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 390);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);

            aIPAddress = new IPAddress(IPData.Skip<byte>(30).Take(4).ToArray());

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = aIPAddress.ToString();
            aLabel.Name = "LabelIDAData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(160, 410);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(aLabel);





            /*
            IPPROTO_IP = 0 Dummy protocol for TCP
            IPPROTO_ICMP = 1   Internet Control Message Protocol
            IPPROTO_IGMP = 2   Internet Group Management Protocol
            IPPROTO_IPIP = 4   IPIP tunnels(older KA9Q tunnels use 94)
            IPPROTO_TCP = 6    Transmission Control Protocol
            IPPROTO_EGP = 8    Exterior Gateway Protocol
            IPPROTO_PUP = 12   PUP protocol
            IPPROTO_UDP = 17   User Datagram Protocol
            IPPROTO_IDP = 22   XNS IDP protocol
            IPPROTO_TP = 29    SO Transport Protocol Class 4
            IPPROTO_DCCP = 33  Datagram Congestion Control Protocol
            IPPROTO_IPV6 = 41  IPv6 header
            */


        }

        private void Facto_Click1(object sender, EventArgs e)
        {
            int DeviceNum = Del_Button_Device(sender);
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            RawCapture aRawCapture = CaptureDeviceList.Instance[DeviceNum].GetNextPacket();      //캡쳐
            Print_TCP(aRawCapture.Data);     //3계층 출력
        }

        private void Facto_Click(object sender, EventArgs e)    //seder에서 자료가 넘어온다.
        {
            int DeviceNum = Del_Button_Device(sender);
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            RawCapture aRawCapture = CaptureDeviceList.Instance[DeviceNum].GetNextPacket();      //캡쳐

            Print_MAC(aRawCapture.Data);    //1계층 출력          
            int iNum = BitConverter.ToInt16(aRawCapture.Data.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);
            if (0x0800 == iNum)
            {
                Print_IP(aRawCapture.Data);     //2계층 출력

                if (6 == aRawCapture.Data[23])//TCP 패킷일 때
                {
                    Print_TCP(aRawCapture.Data);     //3계층 출력
                }



                //MessageBox.show(data1);

                //TextBox aTextBox = new TextBox();
                //aTextBox.Text = data1 + "\r\n" + data2;
                //aTextBox.Location = new Point(120, 120);
                //aTextBox.Name = "FactoTB";
                //aTextBox.Size = new Size(300, 300);
                //aTextBox.Multiline = true;
                //Controls.Add(aTextBox);


                //ListBox로 만든것
                //ListBox aListBox = new ListBox();
                //aListBox.Items.Add(data1);
                //aListBox.Items.Add(data2);
                //aListBox.Location = new Point(120, 120);
                //aListBox.Name = "FactoTB";
                //aListBox.Size = new Size(300, 300);
                //Controls.Add(aListBox);

                //내가 만든 거
                //TextBox aTextBox = new TextBox();
                //aTextBox.Text = Text;      //Ul의 나타는 글자를 나타낸다.
                //aTextBox.Name = "Facto" ;     //그 차제의 이름을 나타낸다.
                //aTextBox.Location = new Point(120, 120);    //point는 위치 확인을 위해서 
                //aTextBox.Click += new EventHandler(Facto_Click);
                //Controls.Add(aTextBox);



            }

        }


    }
}