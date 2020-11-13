using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 100;

            Object aObject = iNum1; //Boxing : iNum1을 Object에 싼다

            int iNum2 = (int)aObject; //UnBoxing : Object을 iNum2에 푼다.

            Console.WriteLine(iNum1);
            Console.WriteLine(aObject);
            Console.WriteLine(iNum2);


        }
    }
}
