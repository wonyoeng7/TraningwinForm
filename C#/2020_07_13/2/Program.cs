using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 144, 123, 232, 324, 789 };

            int index = System.Array.IndexOf(Array,324);    //검색 기능

            Console.WriteLine(index);
            for (int Count = 0; Count < Array.Length; ++Count)
            {
                if (324 == Array[Count])
                {
                    Console.WriteLine("찾았다!! : " + Count);
                    Console.WriteLine("찾았다!! : {0}", Count);
                    break;
                }
            }

            //Console.WriteLine("찾았다!! : {0}", System.Array.IndexOf(Array, 324));  위에 for문과 동일하다 



        }
    }
}
