//프롤로그 시작
using System;
//프롤로그 끝

namespace _2020_06_25    //예를 들어서 부서라고 생각하면 된다. 
{
    class Program  //클래스
    {
        static void Main(string[] args) // Main 메소드 & Entry Point
        // Main 메소드의 인자/인수/매개변수 : 1개, 이름 : args
        {
            Console.WriteLine("지옥으로 키티");
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine("{0:X}", 100);

            Console.Write("문자를 입력하세요:");
            string inValue = Console.ReadLine();
            Console.WriteLine("{0}",inValue);
        }
    }
}
