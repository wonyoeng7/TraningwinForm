using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        public static void MethodA()
        {
            System.Console.WriteLine("메소드 A입니다.");
        }

        public static void MethodB()
        {
            MethodA();
            System.Console.WriteLine("메소드 B입니다.");
            MethodA();
        }

        public static void Main(string[] args)
        {
            MethodB();
            MethodA();
        }
    }
}
