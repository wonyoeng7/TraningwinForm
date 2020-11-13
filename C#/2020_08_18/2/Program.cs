using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {

        static void ArrayIntCopy(int[] Dst, int[] Src)
        {
            for (int i = 0; i < Dst.Length; i++)
            {
                Dst[i] = Src[i];
            }
        }


        static void ArrayDoubleCopy(Double[] Dst, Double[] Src)
        {
            for (int i = 0; i < Dst.Length; i++)
            {
                Dst[i] = Src[i];
            }
        }

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
            int[] ArrayInt1 = { 2, 4, 6, 8 };
            int[] ArrayInt2 = new int[4];

            ArrayPrint<int>(ArrayInt1);
            ArrayPrint<int>(ArrayInt2);

            ArrayIntCopy(ArrayInt2, ArrayInt1);
            ArrayPrint<int>(ArrayInt2);
            Console.WriteLine("-----------------------");

            Double[] ArrayDouble1 = { 2.1, 4.1, 6.1, 8.1 };
            Double[] ArrayDouble2 = new Double[4];

            ArrayPrint<Double>(ArrayDouble1);
            ArrayPrint<Double>(ArrayDouble2);

            ArrayDoubleCopy(ArrayDouble2, ArrayDouble1);
            ArrayPrint<Double>(ArrayDouble2);

        }
    }
}
