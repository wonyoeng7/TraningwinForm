using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string[] Map = new string[10] { "GGGGGGGGGGGGGGGG",    //0
                                               "G##############G",    //1
                                               "G#            #G",    //2
                                               "G# ############G",    //3
                                               "G#       .B.@ #G",    //4 
                                               "G#            #G",    //5
                                               "G#            #G",    //6
                                               "G#            #G",    //7
                                               "G##############G",    //8
                                               "GGGGGGGGGGGGGGGG"};   //9

        static void Main(string[] args)
        {
            char[][] TT = new char[10][];

            for (int i = 0; i < Map.Length; i++)
            {
                TT[i] = Map[i].ToCharArray();
            }

            
            foreach (var A in TT)
            {
                foreach (var Temp in A)
                {
                    Console.Write(Temp);
                }
                Console.WriteLine();
            }
            

            /*
            TT[0] = Map[0].ToCharArray();
            TT[1] = Map[1].ToCharArray();
            TT[2] = Map[2].ToCharArray();
            TT[3] = Map[3].ToCharArray();
            TT[4] = Map[4].ToCharArray();
            TT[5] = Map[5].ToCharArray();
            TT[6] = Map[6].ToCharArray();
            TT[7] = Map[7].ToCharArray();
            TT[8] = Map[8].ToCharArray();
            TT[9] = Map[9].ToCharArray();
            */

        }
        static void Main2(string[] args)
        {
            char[] TT0 = Map[0].ToCharArray();
            char[] TT1 = Map[1].ToCharArray();
            char[] TT2 = Map[2].ToCharArray();
            foreach (var Temp in TT1)
            {
                Console.Write(Temp);
            }
            Console.WriteLine();


        }

        static void Main1(string[] args)
        {


            char[] TT1 = Map[0].ToCharArray();
            TT1[1] = '#';
            foreach (var Temp in TT1)
            {
                Console.Write(Temp);
            }
            Console.WriteLine();

            foreach (var Temp in Map[0])
            {
                Console.Write(Temp);
            }
            Console.WriteLine();
        }
            
        
    }
}
