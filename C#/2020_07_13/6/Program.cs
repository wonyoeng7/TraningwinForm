using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] TTT) //arguments : args라 한다. arg말고 다른거 써도 된다.
        {
            //Console.WriteLine(args.Length);
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            if( 0 == TTT.Length)
            {
                Console.WriteLine("그냥 열기");
            }
            else if (  1 == TTT.Length)
            {
                Console.WriteLine("{0} 파일 이름으로 열기",TTT[0]);
            }

        }
    }
}
