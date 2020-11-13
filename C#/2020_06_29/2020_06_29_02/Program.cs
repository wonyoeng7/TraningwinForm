using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_29_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] iArray =new int[5] { 0, 1, 2, 3, 4 };  밑에 코드랑 동일
            int[] iArray;
            iArray = new int[5] { 0, 1, 2, 3, 4 };

           // int[] iArray = new int[50]{
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4,
           //     0,1,2,3,4
           //};

           

            //for (int i = 0; i < iArray.Length; ++i)
            //{
            //    Console.WriteLine(iArray[i]);
            //}

            //foreach (int i  in   iArray)
            //{
            //    Console.WriteLine(iArray[i]);
            //}

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    continue;  // continue문은 밑에 위로 가겠다.
                Console.WriteLine("{0}", i);

            }
            Console.WriteLine();
            for (int i = 0; i < 10;i++ )
            {
                if (i % 2 == 1)
                    break;  // break문은 바깥으로 나가겠다.
                Console.WriteLine("{0}", i);

            }
            Console.WriteLine();


        }
    }
}
