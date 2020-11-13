using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Coordinate
    {
        public int x;  
        public int y;  

    }
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate();
            Coordinate c2 = new Coordinate();

            c1.x = 1;
            c1.x = 2;
            c2.x = 1;
            c2.x = 2;

            Console.WriteLine("c1= {0},{1}", c1.x, c1.y);
            Console.WriteLine("c2= {0},{1}", c2.x, c2.y);

            c1 = c2;
            if(c1 == c2)
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다");
            }

            c1.x = 100;

            Console.WriteLine("c1= {0},{1}", c1.x, c1.y);
            Console.WriteLine("c2= {0},{1}", c2.x, c2.y);

   
        }
    }
}
