﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void TwoPrint<T1,T2>(T1 Arg1, T2 Arg2)
        {
            Console.WriteLine(Arg1);
            Console.WriteLine(Arg2);
        }

        static void Main(string[] args)
        {
            TwoPrint(3, 2.1);
            Console.WriteLine("------------------");
            TwoPrint("헬로", 4.0f);
        }
    }
}
