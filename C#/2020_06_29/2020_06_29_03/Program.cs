using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_29_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float c = 0;

            while (true)
            {
                try
                {
                    Console.Write("변수1을 입력하세요 :");
                    a = int.Parse(Console.ReadLine());      //try에 여기에서 에러가 발생하면 밑에는 작동하지 않고 바로 catch로 넘어간다.
                    Console.Write("변수2을 입력하세요 :");
                    b = int.Parse(Console.ReadLine());
                    c = a / b;

                }

                catch (DivideByZeroException eObj)   // eObj는 사용하지 않는데 왜 넣었는지 물어보는거다 
                {
                    Console.WriteLine(eObj);
                    Console.WriteLine("변수의 값이 올바르지 않습니다.");
                    continue;

                }
                catch (FormatException eObj)
                {
                    Console.WriteLine(eObj);
                    Console.WriteLine("숫자를 입력하시지 않았습니다.");
                    continue;
                }



                finally
                {
                    Console.WriteLine("프로그램이 실행 되었습니다.");
                }
                Console.WriteLine("A/B값은 {0}입니다.", c);
                break;
            }
        }
    }
}
