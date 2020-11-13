using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Temp1 = new string[]
            {
                "GGGGGGGGGGGGGGGG",    //0
                "G##############G",    //1
                "G#            #G",    //2
                "G#           ##G",    //3
                "G#       BB..@#G",    //4 
                "G#            #G",    //5
                "G#            #G",    //6
                "G#            #G",    //7
                "G##############G",    //8
                "GGGGGGGGGGGGGGGG"     //9
            };
            string[] Temp2 = new string[]
{
                "G##############G",    //0
                "G##############G",    //1
                "G#            #G",    //2
                "G#           ##G",    //3
                "G#       BB..@#G",    //4 
                "G#            #G",    //5
                "G#            #G",    //6
                "G#            #G",    //7
                "G##############G",    //8
                "GGGGGGGGGGGGGGGG"     //9
};

            List<string[]> aList = new List<string[]>();

            aList.Add(Temp1);
            aList.Add(Temp2);
            stirng[][] map = aList.ToArray();

            //foreach (var item0 in aList[0])
            //{
            //    Console.WriteLine(item0);
            //}
            //foreach (var item1 in aList[1])
            //{
            //    Console.WriteLine(item1);
            //}
            //string[][] Map = aList.ToArray();

            //foreach (var item in Map[0])
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in Map[1])
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
