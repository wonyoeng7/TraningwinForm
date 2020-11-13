using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAll(1.05, "Result", 3);

        }
        private static void PrintAll(params object[] values)
        {
            foreach (Object value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
