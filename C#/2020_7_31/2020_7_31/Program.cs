using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020_7_31
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Thread t1 = new Thread(threadFunc1);
            Thread t2 = new Thread(threadFunc2);
            Thread t3 = new Thread(threadFunc3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("메인 스레드 종료");

        }
        static void threadFunc1()
        {
            Console.WriteLine("15초 후에 프로그램 종료");
            Thread.Sleep(1000 * 15);        //60초 동안 실행 중지   sleep은 ms초 하기에 1000을 곱해서 1초로 만들어 놓음
                                            //현재 주 스레드는 종료됐어도 t 스레드는 존속한다.

            Console.WriteLine("스레드 종료!");
        }

        static void threadFunc2()
        {
            Console.WriteLine("10초 후에 프로그램 종료");
            Thread.Sleep(1000 * 10);        

            Console.WriteLine("스레드 종료!");
        }

        static void threadFunc3()
        {
            Console.WriteLine("5초 후에 프로그램 종료");
            Thread.Sleep(1000 * 5);
            
            Console.WriteLine("스레드 종료!");
        }

    }
}
