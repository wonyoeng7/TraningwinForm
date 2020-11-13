using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[4];
            int[,] Array2 = new int[2, 3];
            int[,,] Array3 = new int[2, 4, 3];

            Console.WriteLine("Array1의 차원 : " + Array1.Rank);
            Console.WriteLine("Array2의 차원 : " + Array2.Rank);
            Console.WriteLine("Array3의 차원 : " + Array3.Rank);

            Console.WriteLine("");

            Console.WriteLine("Array1의 크기 : " + Array1.Length);
            Console.WriteLine("Array2의 크기 : " + Array2.Length);
            Console.WriteLine("Array3의 크기 : " + Array3.Length);

        }
    }
}
