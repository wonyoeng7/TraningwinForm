using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _7
{
    public partial class Form1 : Form
    {
        const int WTileSize = 16;
        const int HTileSize = 9;
        const string Title = "푸시푸시 [Stage : ";
        bool EndGame;

        int KeyCount;
        int Stage;
        
        char[][] MapReal;
        string[,] Map = {{         "####    ########",//0
                                   "###   @B  ######",//1
                                   "###       ######",//2
                                   "###       ######",//3
                                   "###  B    ######",//4
                                   "###       ######",//5
                                   "###   ..  ######",//6
                                   "###       ######",//7
                                   "################",//8
                                 },
                                 { "####    ########",//0
                                   "###   @B  ######",//1
                                   "###       ######",//2
                                   "###     ########",//3
                                   "###  B    ######",//4
                                   "###       ######",//5
                                   "###   ..  ######",//6
                                   "### ####  ######",//7
                                   "################",//8
                                                    }
            };


        Image Human;
        Image HumanR;
        Image HumanL;
        Image HumanB;
        Image HumanF;

        int XHuman;
        int YHuman;
        int XHumanOld;
        int YHumanOld;

        Image Wall;
        Image Road;
        Image Box;
        Image Dot;
        int WTile;
        int HTile;


        public Form1()
        {
            InitializeComponent();

            
            Stage = 0;
            HumanR = new Bitmap(Properties.Resources.HumanR);
            WTile = HumanR.Width;
            HTile = HumanR.Height;
            ClientSize = new Size(WTileSize * WTile, HTileSize * HTile);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            HumanB = new Bitmap(Properties.Resources.HumanB);
            HumanF = new Bitmap(Properties.Resources.HumanF);
         
           
            Wall = new Bitmap(Properties.Resources.Wall);
            Road = new Bitmap(Properties.Resources.Road);
            Box = new Bitmap(Properties.Resources.Box);
            Dot = new Bitmap(Properties.Resources.Dot);

            XHuman = 0;
            YHuman = 0;
         
            LoadMap();


        }
        private void LoadMap()
        {
            MapReal = new char[HTileSize][];
            for (int i = 0; i < HTileSize; ++i)
            {
                MapReal[i] = Map[Stage, i].ToCharArray();
            }
            KeyCount = 0;
            Human = HumanF;
            Refresh();

        }
        private void Move()
        {
           
            

            if ('#' == MapReal[YHuman][XHuman])
            {
                return;
            }
            if ('B' == MapReal[YHuman][XHuman])
            {
                if ('#' == MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld])
                {
                    return;
                }
                if ('B' == MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld])
                {
                    return;
                }
                MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld] = 'B';
            }

            if ('.' == Map[Stage, YHumanOld][XHumanOld])
            {
                MapReal[YHumanOld][XHumanOld] = '.';
            }

            else
            {
                MapReal[YHumanOld][XHumanOld] = ' ';
            }

            MapReal[YHuman][XHuman] = '@';
            ++KeyCount;
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {

            EndGame = true;
            Image Temp = Wall;
            for (int j = 0; j < HTileSize; ++j)
            {
                for (int i = 0; i < WTileSize; ++i)
                {
                    switch(MapReal[j][i])
                    {
                     
                        case '#':
                            Temp = Wall;
                            
                            break;
                        case 'B':
                            Temp = Box;
                            if('.' != Map[Stage,j][i])
                            {
                                EndGame = false;
                            }
                            break;
                        case '.':
                            Temp = Dot;
                            break;
                        case ' ':
                            Temp = Road;
                            break;
                        case '@':
                            Temp = Human;
                            XHuman = i;
                            YHuman = j;                          
                            break;
                        default:
                            return;
                    }
                    
                    e.Graphics.DrawImage(Temp, WTile * i, HTile * j);

                }
                Text = Title + (Stage + 1) + "[" + KeyCount + "]";
            }
            /////////////////////////
            //Text = Title + EndGame;

           




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //if(Keys.Left == e.KeyCode)  //왼쪽 방향키를 눌렀다는 뜻
            //{
            //    XHuman = XHuman - 10;
            //    Refresh();

            //}

            //else if (Keys.Right == e.KeyCode)  //오른쪽 방향키를 눌렀다는 뜻
            //{
            //    XHuman = XHuman + 10;
            //    Refresh();
            //}

            //else if (Keys.Up == e.KeyCode)  //위쪽 방향키를 눌렀다는 뜻
            //{
            //    YHuman = YHuman - 10;
            //    Refresh();
            //}

            //else if (Keys.Down == e.KeyCode)  //아래쪽 방향키를 눌렀다는 뜻
            //{
            //    YHuman = YHuman + 10;
            //    Refresh();
            //}

            YHumanOld = YHuman;
            XHumanOld = XHuman;
            switch (e.KeyCode)
            {
                case Keys.F5:
                    if (DialogResult.Yes == MessageBox.Show("다시 시작할까요?", "선택", MessageBoxButtons.YesNo))
                    {
                        LoadMap();
                    }
                    return;

                case Keys.Left:
                    --XHuman;
                    Human = HumanL;
                    break;

                case Keys.Right:
                    ++XHuman; 
                    Human = HumanR;
                    break;

                case Keys.Up:
                    --YHuman;
                    Human = HumanB;
                    break;

                case Keys.Down:
                    ++YHuman;
                    Human = HumanF;
                    break;

                default:
                    return;
            }
            Move();
            Refresh();
            if (true == EndGame)
            {
                
                ++Stage;
                if (Stage == Map.Length/HTileSize)
                {
                    MessageBox.Show("게임을 종료합니다.", "알림", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
                MessageBox.Show("다음판으로 이동합니다.", "알림", MessageBoxButtons.OK);
                LoadMap();
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
        

        
  


    

