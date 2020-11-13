using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_08_18
{
    class T
    {

        static void ArrayDoublePrint(double[] Num)
        {
            
            for (int i = 0; i < Num.Length; i++)
            {
                Console.Write("{0} ", Num[i]);
            }
            Console.WriteLine();
        }

        static void ArrayIntPrint(int[] Num)
        {

            for (int i = 0; i < Num.Length; i++)
            {
                Console.Write("{0} ", Num[i]);
            }
            Console.WriteLine();
        }

        static void ArrayStringPrint(string[] Num)
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
            ArrayIntPrint(Numbers1);
            double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };
            ArrayDoublePrint(Numbers2);
            string[] Numbers3 = { "일", "이"};
            ArrayStringPrint(Numbers3);



        }
    }
}
