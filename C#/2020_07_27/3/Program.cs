using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {   Unsafe
            { int iNum = 100;
                Console.WriteLine("{0:x}", (int)&iNum);
            }
        }
    }
}
