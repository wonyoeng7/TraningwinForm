using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            int[] SortArray = new int[5] { 15, 32, 11, 20, 43 };

            Console.WriteLine("현재배열 출력 :");
            for(i = 0; i < SortArray.Length; i++)
            {
                Console.WriteLine(SortArray[i]);
            }

            //foreach (int e in SortArray)
            //{
            //    Console.WriteLine(e);
            //}

            System.Array.Sort(SortArray);  //sort는 정렬을 해주는 메소드이다.

            Console.WriteLine("정렬된 배열 출력 :");
            for (i = 0; i < SortArray.Length; i++)
            {
                Console.WriteLine(SortArray[i]);
            }
        }
    }
}
