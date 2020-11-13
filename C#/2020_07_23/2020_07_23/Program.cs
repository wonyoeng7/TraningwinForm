using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_23
{
    class Program
    {
        delegate int Calculator(int iNum1, int iNum2);

        static int Add(int iNum1,int iNum2)
        {
            return iNum1 + iNum2;
        }
        static int Div(int iNum1, int iNum2)
        {
            return iNum1 / iNum2;
        }
        static int Mul(int iNum1, int iNum2)
        {
            return iNum1 * iNum2;
        }
        static int Sub(int iNum1, int iNum2)
        {
            return iNum1 - iNum2;
        }


        static void Main(string[] args)
        {
            int iResult;
            
            Calculator[] aCalculator = new Calculator[] { Add , Sub, Mul, Div };

            for (int i = 0; i < aCalculator.Length; ++i)
            {
                
                iResult = aCalculator[i](3, 4);
                Console.WriteLine(iResult);

            }

            Console.WriteLine("////////////////////////////////////////");

            foreach (Calculator temp in aCalculator)
            {
                iResult = temp(3, 4);
                Console.WriteLine(iResult);
            }

            Console.WriteLine("////////////////////////////////////////");
            iResult = Add(3, 4);         
            Console.WriteLine(iResult);

            iResult = Sub(3, 4);
            Console.WriteLine(iResult);

            iResult = Mul(3, 4);
            Console.WriteLine(iResult);

            iResult = Div(3, 4);
            Console.WriteLine(iResult);

            


        }
    }
}
