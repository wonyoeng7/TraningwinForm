using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _LINQTest_
{
    class Program
    {
        static void Print(List<int> aList)
        {
            foreach (var Temp in aList)
            {
                Console.WriteLine(Temp);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> aList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> aList2 ;

            //var Fact = from Temp in aList1 select Temp;
            //aList2 = Fact.ToList<int>();
            aList2 = (from Temp in aList1 select Temp).ToList<int>();   //임시객체가 생성된다 이줄이 끝난면 사라진다.


            Print(aList2);


        }


            static void Main1(string[] args)
        {
            List<int> aList1 = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            List<int> aList2 = new List<int>();

            foreach (var Temp in aList1)
            {
                aList2.Add(Temp);
            }
            Print(aList1);
            Print(aList2);
        }
      

            
    }
}
