using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct2
{
    //ref와 out에 대한 설명
    class Program
    {
        static void test1(int iArg1, ref int iArg2)
        {
            iArg1 = 100;
            iArg2 = 200;
        }

        static void test2(int iArg1,out int iArg2)
        {
            iArg1 = 100;
            iArg2 = 200;
        }

        static void Main(string[] args)
        {
            //int iNum1 = 1000;
            //int iNum2 = 2000;

            //test1(iNum1, ref iNum2);    //ref(레퍼런스)로 스택영역에 있는 변수를 수정할수 있다.

            //Console.WriteLine(iNum1);
            //Console.WriteLine(iNum2);   //레퍼런스 전달을 해서 변하는거다.

            int iNum1 = 1000;
            int iNum2;

            test1(iNum1, ref iNum2);   //ref은 인자를 초기화 안하면 못넘긴다. 메소드 쪽에서 값을 넣어줘야한다.

            Console.WriteLine(iNum1);
            Console.WriteLine(iNum2);   

            test2(iNum1, out iNum2);    //변수값을 수정하게 되어있다.

            Console.WriteLine(iNum1);
            Console.WriteLine(iNum2);   
        }
    }
}
