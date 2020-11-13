using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Test(int[] var)

        {
            Console.WriteLine(var.Length);
        }

        static void Main(string[] args)
        {
            int[] Array = new int[5];
            Test(Array);

        }
    }
}
