using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class T
    {

        static void ArrayPrint<T>(T[] Num)
        {

            for (int i = 0; i < Num.Length; i++)
            {
                Console.Write("{0} ", Num[i]);
            }
            Console.WriteLine();
        }

       
        static void Main(string[] args)
        {
            int[] Numbers1 = { 1, 3, 5, 7, 9 };
            double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };
            string[] Numbers3 = { "일", "이" };
            ArrayPrint<int>(Numbers1);
            ArrayPrint<double>(Numbers2);
            ArrayPrint<string>(Numbers3);

        }
    }
