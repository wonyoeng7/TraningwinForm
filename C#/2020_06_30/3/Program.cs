using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        public static ulong Factorial(ulong number)
        {
            if (number < 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
        public static void Main(string[] args)
        {
            ulong nfact = Factorial(5);
            Console.WriteLine("5 * 4 * 3 * 2 * 1 = " + nfact);
        }       
    }
}
