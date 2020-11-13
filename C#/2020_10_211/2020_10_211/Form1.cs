using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_10_211
{
    public partial class Form1 : Form
    {
        //그림이랑 문자를 호환 Mapping이라 한다.
        Bitmap Box;         //'B'
        Bitmap Point;       //'.'
        Bitmap Human;       //'@'
        Bitmap HumanF;       //'@'
        Bitmap HumanB;       //'@'
        Bitmap HumanR;       //'@'
        Bitmap HumanL;       //'@'
        Bitmap Wall;        //'#'
        Bitmap Road;        //''
        Bitmap Gound;       //'G'

        /// /////////////////////////////////////////////////
        /// Right Display

        Label lStageData = new Label();
        Label lTCountData = new Label();
        Label lCountData = new Label();

        private void SetRlint()
        {
            SetRlintLabel();
            SetRlintButton();
        }

        private void SetRlintButton()
        {
            Font aFont = new Font("Courier New", 12);

            Button Temp = new Button();
            Temp.Size = new Size(50 , 50);
            Temp.Location = new Point(875, 300);
            Temp.Font = aFont;
            Temp.Text = "←";
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Click += new System.EventHandler(this.bArrowLeft_Click);
            Temp.TabStop = false;
            Controls.Add(Temp);


            Temp = new Button();
            Temp.Size = new Size(50, 50);
            Temp.Location = new Point(975, 300);
            Temp.Font = aFont;
            Temp.Text = "→";
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Click += new System.EventHandler(this.bArrowRight_Click);
            Temp.TabStop = false;
            Controls.Add(Temp);


            Temp = new Button();
            Temp.Size = new Size(50, 50);
            Temp.Location = new Point(925, 250);
            Temp.Font = aFont;
            Temp.Text = "↑";
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Click += new System.EventHandler(this.bArrowUp_Click);
            Temp.TabStop = false;
            Controls.Add(Temp);

            Temp = new Button();
            Temp.Size = new Size(50, 50);
            Temp.Location = new Point(925, 350);
            Temp.Font = aFont;
            Temp.Text = "↓";
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Click += new System.EventHandler(this.bArrowDown_Click);
            Temp.TabStop = false;
            Controls.Add(Temp);

            Temp = new Button();
            Temp.Size = new Size(150, 50);
            Temp.Location = new Point(875, 200);
            Temp.Font = aFont;
            Temp.Text = "HOME";
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Click += new System.EventHandler(this.bHome_Click);
            Temp.TabStop = false;
            Controls.Add(Temp);

            Temp = new Button();
            Temp.Size = new Size(150, 50);
            Temp.Location = new Point(875, 400);
            Temp.Font = aFont;
            Temp.Text = "END";
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Click += new System.EventHandler(this.bEnd_Click);
            Temp.TabStop = false;
            Controls.Add(Temp);
        }

        private void SetRlintLabel()
        {
            Font aFont = new Font("Courier New", 12);
            Label lTemp;
            iTMoveCount = 0;

            lTemp = new Label();
            lTemp.Size = new Size(150, 20);
            lTemp.Location = new Point(820, 20);
            lTemp.Font = aFont;
            lTemp.Text = Properties.Resources.StringTitleTotal;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lTemp);

            lTemp = new Label();
            lTemp.Size = new Size(50,20);
            lTemp.Location = new Point(1000, 20);
            lTemp.Font = aFont;
            lTemp.Text = (iFStage + 1).ToString();
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lTemp);

            lTemp = new Label();
            lTemp.Size = new Size(150, 20);
            lTemp.Location = new Point(820, 50);
            lTemp.Font = aFont;
            lTemp.Text = Properties.Resources.StringPresentTitle;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lTemp);

            lStageData.Size = new Size(50, 20);
            lStageData.Location = new Point(1000, 50);
            lStageData.Font = aFont;
            //lStageData.Text = "오류";
            lStageData.TextAlign = ContentAlignment.MiddleCenter;
            lStageData.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lStageData);

            lTemp = new Label();
            lTemp.Size = new Size(150, 20);
            lTemp.Location = new Point(820, 100);
            lTemp.Font = aFont;
            lTemp.Text = Properties.Resources.StringTitleCount;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lTemp);

            lTCountData.Size = new Size(50, 20);
            lTCountData.Location = new Point(1000, 100);
            lTCountData.Font = aFont;
            lTCountData.TextAlign = ContentAlignment.MiddleCenter;
            lTCountData.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lTCountData);

            lTemp = new Label();
            lTemp.Size = new Size(150, 20);
            lTemp.Location = new Point(820, 130);
            lTemp.Font = aFont;
            lTemp.Text = Properties.Resources.StringPresentCount;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lTemp);

            lCountData.Size = new Size(50, 20);
            lCountData.Location = new Point(1000, 130);
            lCountData.Font = aFont;
            lCountData.TextAlign = ContentAlignment.MiddleCenter;
            lCountData.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lCountData);
        }
        ////////////////////////////////////////////////////

        char[][] MapReal;
        string[][] Map;
        const int XTile = 16;
        const int YTile = 10;
        const int XPixel = 50;
        const int YPixel = 50;
        const int XRDisplay = 300;


        int HunmanX;
        int HunmanY;
        int HunmanXOld;         //휴먼의 움직이기전의 좌표를 저장하는 변수
        int HunmanYOld;         //휴먼의 움직이기전의 좌표를 저장하는 변수
        int iStage;             //스테이지의 판수를 나타내는 변수
        int iFStage;
        int iMoveCount;
        int iTMoveCount;

        bool EndStage;          //스테이지가 끝나는지를 확인하는 변수

        public Form1()
        {

            InitializeComponent();
            Text = Properties.Resources.StringTitleGame;
            this.ClientSize = new System.Drawing.Size(XPixel * XTile + XRDisplay, YPixel * YTile);
            Box = new Bitmap(Properties.Resources.Box);
            Point = new Bitmap(Properties.Resources.Point);
            HumanF = new Bitmap(Properties.Resources.HumanF);
            HumanB = new Bitmap(Properties.Resources.HumanB);
            HumanR = new Bitmap(Properties.Resources.HumanR);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            Human = HumanF;
            Wall = new Bitmap(Properties.Resources.Wall);
            Road = new Bitmap(Properties.Resources.Road);
            Gound = new Bitmap(Properties.Resources.Gound);

            OpenMapFile();

            iStage = 1; //스테이지를 나타낸다.
            iFStage = Map.GetLength(0) - 1;
           
            //string Temp = "apple";      // stub코드는 영향을 미치지는 않지만 테스트하기위해서
            MapReal = new char[YTile][];
            LoadMap();
            SetRlint();

            //MessageBox.Show(Map.GetLength(0).ToString());
            //MapReal[0][0] = '#';
        }

        private void OpenMapFile()
        {
            try
            {
                List<string[]> aList = new List<string[]>();
                StreamReader MapFile = new System.IO.StreamReader(@"Map.txt");
                int iCount;
                //int iMapCount = 0;
                string Temp = null;
                string[] TempMap;

                while (true)   // 주석 제거부
                {
                    Temp = MapFile.ReadLine();
                    if (null == Temp)    //파일 끝에 도달
                    {
                        //MessageBox.Show("파일 끝에 도달");
                        //미해결
                        throw new FileNotFoundException();
                        
                    }
                    if (0 == Temp.Length)    //엔터 검색
                    {
                        break;
                    }

                }


                while (true)   // 전체 맵 로딩
                {
                    TempMap = new string[YTile];
                    for (iCount = 0; iCount < YTile; iCount++)      //1개 맵 로딩
                    {
                        
                        Temp = MapFile.ReadLine();
                        if (null == Temp)    //파일 끝에 도달
                        {
                            //MessageBox.Show("맵 로드 중 파일 끝에 도달");
                            break;
                        }

                        if (XTile != Temp.Length)    // 불완전 맵 :맵에 가로 미완성
                        {
                            //MessageBox.Show(iCount + "가로 갯수 부족 : " + Temp.Length.ToString());
                            break;
                        }
                        TempMap[iCount] = Temp;

                    }
                    if (YTile != iCount)     // 맵에 세로 미완성
                    {
                        //MessageBox.Show("세로 갯수 부족 : " + " 다 못읽음 ");

                        while (true) // 다음 앱 검색
                        {
                            if (null == Temp)    //파일 끝에 도달
                            {
                                // 더 이상 읽기 불가
                                break;
                            }
                            if (0 == Temp.Length)    //엔터 확인
                            {
                                break;
                            }

                            Temp = MapFile.ReadLine();


                        }
                        if (null == Temp)    //파일 끝에 도달
                        {
                            // 더 이상 읽기 불가
                            break;
                        }

                    }
                    else
                    {
                        aList.Add(TempMap);     //맵 추가
                        while (true)            //다음맵 검색
                        {
                            Temp = MapFile.ReadLine();

                            if (null == Temp)    //파일 끝에 도달
                            {
                                break;
                            }

                            if (0 == Temp.Length)   //엔터 확인
                            {
                                break;
                            }

                        }   
                    }
                    if (null == Temp)    //파일 끝에 도달
                    {
                        break;
                    }

                }
                if(aList.Count == 0)
                {
                    throw new FileNotFoundException();
                }
                MapFile.Close();
                Map = aList.ToArray();
                //MessageBox.Show(aList.Count.ToString());
            }
            catch (FileNotFoundException)
            {
                //MessageBox.Show("5555555");
                InternalMap();
            }
        }

        private void LoadMap()
        {
            for (int i = 0; i < YTile; i++)
            {
                MapReal[i] = Map[iStage][i].ToCharArray();      //iStage를 통해서 판수를 연결한다.
            }
            lStageData.Text = iStage.ToString();
            //lStageData.Text = (iFStage + 1).ToString();
            iMoveCount = 0;
            lTCountData.Text = iTMoveCount.ToString();
            lCountData.Text = iMoveCount.ToString();

        }

        private void InternalMap()
        {
            Map = new string[][] { new string[]{"GGGGGGGGGGGGGGGG",    //0
                                                "G##############G",    //1
                                                "G#            #G",    //2
                                                "G#           ##G",    //3
                                                "G#       BB..@#G",    //4 
                                                "G#            #G",    //5
                                                "G#            #G",    //6
                                                "G#            #G",    //7
                                                "G##############G",    //8
                                                "GGGGGGGGGGGGGGGG" },  //9

                                   new string[]{"GGGGGGGGGGGGGGGG",    //0
                                                "G##############G",    //1
                                                "G##############G",    //2
                                                "G#    @  ######G",    //3
                                                "G#  ..   ######G",    //4 
                                                "G#  BB        #G",    //5
                                                "G#    #####   #G",    //6
                                                "G#            #G",    //7
                                                "G##############G",    //8
                                                "GGGGGGGGGGGGGGGG"} }; //9
                      
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap abitmap;
            EndStage = true;


            for (int iy = 0; iy < YTile; iy++)
            {

                for (int ix = 0; ix < XTile; ix++)
                {

                    switch (MapReal[iy][ix])
                    {
                        case '#':
                            abitmap = Wall;
                            break;
                        case 'G':
                            abitmap = Gound;
                            break;
                        case '@':
                            abitmap = Human;
                            HunmanX = ix;
                            HunmanY = iy;                            
                            //MessageBox.Show(string.Format("{0} {1}",ix,iy));
                            break;
                        case 'B':

                            abitmap = Box;
                            if(Map[iStage][iy][ix] != '.')              //Box가 .에 들어가지 않게 된다면 계속 돌리게 된다는 뜻이다.
                            {
                                EndStage = false;
                            }
                            break;
                        case '.':
                            abitmap = Point;
                            break;

                        case ' ':
                            abitmap = Road;
                            break;
                        default:
                            abitmap = Road;
                            break;
                    }
                        e.Graphics.DrawImage(abitmap, ix * 50, iy * 50);
                    }
                }
             
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            KeyEventArgs e = new KeyEventArgs(keyData);
            Form1_KeyDown(this, e);
            if(e.KeyData == (Keys.Alt | Keys.F4))
            {
                Application.Exit(); 
            }

            //return base.ProcessCmdKey(ref msg, keyData);  //뒤에 넘기는 부분
            return true;    //안넘기는 부분

        }
        private void bArrowLeft_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.Left));
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.Home));
        }


        private void bEnd_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.End));
            
        }


        private void bArrowRight_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.Right));
        }

        private void bArrowUp_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.Up));
        }

        private void bArrowDown_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.Down));
        }


        private void StageStart()
        {
            LoadMap();
            Human = HumanF;
            Refresh();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            MapReal[HunmanY][HunmanX] = ' ';
            HunmanXOld = HunmanX;
            HunmanYOld = HunmanY;
            switch (e.KeyCode)
            {
                case Keys.End:
                    if (DialogResult.Cancel == MessageBox.Show(Properties.Resources.StirngEndMessage, Properties.Resources.StringCapEnd, MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                    if (iFStage == iStage)
                    {
                        MessageBox.Show(Properties.Resources.StringlimitMessage);
                        return;
                    }
                    ++iStage;
                    StageStart();
                    return;


                case Keys.Home:
                    if(DialogResult.Cancel == MessageBox.Show(Properties.Resources.StringRestartMessage,Properties.Resources.StringCapRestart, MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                    StageStart();
                    return;

                case Keys.Left:
                    Human = HumanL;
                    if (MapReal[HunmanY][HunmanX - 1] == '#')        //벽이면 막히게 하는 코드
                    {
                        break;
                        //return;
                    }
                    if (MapReal[HunmanY][HunmanX - 1] == 'B')       
                    {
                        if (MapReal[HunmanY][HunmanX - 2] == '#')       //박스가 벽에 부딪히면 막히는 코드라큥 쁑 \ㅇ.-/
                        {
                            return;
                        }
                        if (MapReal[HunmanY][HunmanX - 2] == 'B')       //박스가 박스가 겹치게 되면 막히는 코드라큥 쀼 \ㅇ.ㅇ/
                        {
                            return;
                        }
                        MapReal[HunmanY][HunmanX - 2] = 'B';

                    }
                    --HunmanX;
                    break;
                case Keys.Right:
                    Human = HumanR;
                    if (MapReal[HunmanY][HunmanX + 1] == '#')
                    {
                        break;
                        //return;
                    }
                    if (MapReal[HunmanY][HunmanX + 1] == 'B')
                    {
                        if (MapReal[HunmanY][HunmanX + 2] == '#')
                        {
                            return;
                        }
                        if (MapReal[HunmanY][HunmanX + 2] == 'B')
                        {
                            return;
                        }


                        MapReal[HunmanY][HunmanX + 2] = 'B';
                       
                    }
                    ++HunmanX;
                    break;
                case Keys.Down:
                    Human = HumanF;
                    if (MapReal[HunmanY + 1][HunmanX] == '#')
                    {
                        break;
                        //return;
                    }
                    if (MapReal[HunmanY + 1][HunmanX] == 'B')
                    {
                        if (MapReal[HunmanY + 2][HunmanX] == '#')
                        {
                            return;
                        }

                        if (MapReal[HunmanY + 2][HunmanX] =='B')
                        {
                            return;
                        }
                        MapReal[HunmanY + 2][HunmanX] = 'B';
                        
                    }
                    ++HunmanY;
                    break;
                case Keys.Up:
                    Human = HumanB;
                    if (MapReal[HunmanY - 1][HunmanX] == '#')
                    {
                        break;
                        //return;
                    }
                    if (MapReal[HunmanY - 1][HunmanX] == 'B')
                    {
                        if (MapReal[HunmanY - 2][HunmanX] == '#')
                        {
                            return;
                        }
                        if (MapReal[HunmanY - 2][HunmanX] == 'B')
                        {
                            return;
                        }

                        MapReal[HunmanY - 2][HunmanX] = 'B';
                       
                    }
                    --HunmanY;
                    break;
                default:
                    MapReal[HunmanY][HunmanX] = '@';
                    return;

            }
            if((HunmanY != HunmanYOld) || (HunmanX != HunmanXOld))
            {
                ++iMoveCount;
                lTCountData.Text = (iTMoveCount + iMoveCount).ToString();
                lCountData.Text = iMoveCount.ToString();
            }
          

            if (Map[iStage][HunmanYOld][HunmanXOld] == '.')        
            {
                MapReal[HunmanYOld][HunmanXOld] = '.';
            }
            MapReal[HunmanY][HunmanX] = '@';
            Refresh();
            if (EndStage)               //박스가 포인트에 다 들어가게 되면 메세지박스가 뜬다.
            {
                //MessageBox.Show(iStage.ToString());
                //MessageBox.Show(iFStage.ToString());
                if (iFStage == iStage)
                {
                    MessageBox.Show(Properties.Resources.StringLastMessage);
                    Application.Exit();
                }
                MessageBox.Show(Properties.Resources.StringNextMessage);
                ++iStage;
                iTMoveCount = iTMoveCount + iMoveCount;
                LoadMap();
                Refresh();
            }
          //번쩍거림을 없애기 위해서 더블버퍼링을 켰다.
        }

    }

    }


