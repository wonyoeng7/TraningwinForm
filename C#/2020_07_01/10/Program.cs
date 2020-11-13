using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] Original = { 5, 4, 2, 6, 7, 1 };
            int[] Clone = (int[])Original.Clone();
            
            for(i = 0; i <Clone.Length;i++)
            {
                Console.WriteLine(Clone[i]);
            }
            Original[3] = 20;
            Console.WriteLine("복제배열[3] :" + Clone[3] );
        }
    }
}
