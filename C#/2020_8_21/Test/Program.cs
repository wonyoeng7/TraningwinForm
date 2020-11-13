using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aList = new List<int>();

            Console.WriteLine("capa : {0}, Cnt : {1}", aList.Capacity,aList.Count); 
            aList.Add(100);
            Console.WriteLine("capa : {0}, Cnt : {1}", aList.Capacity, aList.Count);
            aList.Add(100);
            Console.WriteLine("capa : {0}, Cnt : {1}", aList.Capacity, aList.Count);
            aList.Add(100);

        }
    }
}
