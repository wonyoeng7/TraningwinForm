using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ClearArray = { 5, 4, 2, 6, 7, 1 };

            Console.WriteLine("************클리어 전***************");
            foreach(int iNum in ClearArray)
            {
                Console.WriteLine(iNum);
            }

            System.Array.Clear(ClearArray, 0, ClearArray.Length);
            Console.WriteLine("************클리어 후***************");
            foreach (int iNum in ClearArray)
            {
                Console.WriteLine(iNum);
            }


        }
    }
}
