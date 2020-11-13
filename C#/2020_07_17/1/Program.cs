using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{

   
    class Coordinate
    {
        public int x;   //힙영역
        public int y;   //힙영역

    }

    class ConsoleApplication
    {
    
        static Coordinate test()
        {
            Coordinate temp = new Coordinate();
            return temp;
        }

        static void Main1(string[] args)
        {
            Coordinate c = test();
            c.x = 1;
            c.y = 2;

            Console.WriteLine("c = {0},{1}", c.x, c.y);
            c = null;


            try
            {             
                c.x = 1;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("c가 널을 가지고 있잖아. 확인하고 쓰셈!!!");
            }

        }
    }
}
