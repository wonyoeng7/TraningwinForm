using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class Example
    {
        public int vari = 0;
        public Example()
        {
            vari++;
        }
        public static void Main(string[] args)
        {
            Example e1 = new Example();
            Example e2 = new Example();
            Console.WriteLine(e1.vari);
            Console.WriteLine(e2.vari);
        }
    }
}
