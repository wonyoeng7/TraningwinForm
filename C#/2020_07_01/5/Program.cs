using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("행의 갯수를 입력 하세요");
            string s1 = System.Console.ReadLine();

            System.Console.WriteLine("열의 갯수를 입력 하세요");
            string s2 = System.Console.ReadLine();

            int rows = int.Parse(s1);
            int cols = int.Parse(s2);

            int[,] myArray = new int[rows, cols];
            System.Console.WriteLine(rows + "*" + cols + "배열이 생성되었습니다.");


        }
    }
}
