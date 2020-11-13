using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static double Add(double Num1, double Num2)
        {
            double Num3 = Num1 + Num2;

            return Num3;
        }
        static float Add(float Num1, float Num2)
        {
            float Num3 = Num1 + Num2;

            return Num3;
        }
        static int Add(int iNum1, int iNum2)
        {
            int iNum3 = iNum1 + iNum2;

            return iNum3;
        }
        /*
        static float Add(int iNum1, int iNum2)
        {
            float iNum3 = iNum1 + iNum2;

            return iNum3;
        }*/
        static double AddDouble(double Num1, double Num2)
        {
            double Num3 = Num1 + Num2;

            return Num3;
        }
        static float AddFloat(float Num1, float Num2)
        {
            float Num3 = Num1 + Num2;

            return Num3;
        }
        static int AddInt(int iNum1, int iNum2)
        {
            int iNum3 = iNum1 + iNum2;

            return iNum3;
        }
        static void Main(string[] args)
        {
            int Num1 = 3;
            int Num2 = 4;
            int Num3 = Num1 + Num2;

            Console.WriteLine("{0} = {1} + {2}", Num3, Num1, Num2);

            int iNum4 = AddInt(5, 6);
            Console.WriteLine("{0} = {1} + {2}", iNum4, 5, 6);

            float fNum4 = AddFloat(5.1f, 6.1f);
            Console.WriteLine("{0} = {1} + {2}", fNum4, 5.1f, 6.1f);

            double dNum4 = AddDouble(5.1, 6.1);
            Console.WriteLine("{0} = {1} + {2}", dNum4, 5.1, 6.1);



            int iNum5 = Add(5, 6);
            //int iNum6 = Add("5", "6");

        }
    }
}