using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] ClearArray = { 5, 4, 2, 6, 7, 1 };
            System.Array.Clear(ClearArray, 1, 2);

            for (i = 0; i < ClearArray.Length;i++)
            {
                Console.WriteLine(ClearArray[i]);
            }
        }
    }
}
