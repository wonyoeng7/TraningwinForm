using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] Original = { 5, 4, 2, 6, 7, 1 };
            int[] Clone = (int[])Original.Clone();

            Console.WriteLine("Original :");
            foreach (int one in Original)
                Console.Write(one + " ");
            Console.WriteLine();

            Console.WriteLine("Clone :");
            foreach (int one in Clone)
                Console.Write(one + " ");
            Console.WriteLine();

            Console.WriteLine("**********************************");
            System.Array.Sort(Clone);

            Console.WriteLine("Original :");
            foreach (int one in Original)
                Console.Write(one + " ");
            Console.WriteLine();

            Console.WriteLine("Clone :");
            foreach (int one in Clone)
                Console.Write(one + " ");
            Console.WriteLine();
        }
    }
}
