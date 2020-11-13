using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    
    class FACT<T1,T2>
    {
        public T1 Value;
        public T2 Value2;

        public void Print()
        {
            Console.WriteLine("FACT Value = {0} {1}", Value, Value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FACT<int, string> obj = new FACT<int, string>();
            obj.Value = 100;
            obj.Value2 = "백";
            obj.Print();
        }
    }
}
