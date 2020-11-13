using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }

        static int Add(params int[] values)
        {
            int result = 0;
            
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            return result;
        }
        
    }
}
