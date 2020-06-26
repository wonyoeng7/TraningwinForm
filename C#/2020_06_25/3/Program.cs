using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    enum Week
    {
        Mon = 100,
        Tue,
        Wed,
        Thu = 200,
        Fri,
        Sat,
        Sun
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week GoodDay;
            Week ToDay;

            GoodDay = Week.Fri;
            ToDay = Week.Thu;

            Console.WriteLine("GoodDay = {0}", GoodDay);
            Console.WriteLine("ToDay = {0}", ToDay);

            Console.WriteLine("GoodDay Index = {0}", (int)GoodDay);
            Console.WriteLine("ToDay Index = {0}", (int)ToDay);

            Console.WriteLine("ToDay Index = {0}", (int)Week.Mon);
            Console.WriteLine("ToDay Index = {0}", (int)Week.Tue);
            Console.WriteLine("ToDay Index = {0}", (int)Week.Wed);
            Console.WriteLine("ToDay Index = {0}", (int)Week.Thu);
            Console.WriteLine("ToDay Index = {0}", (int)Week.Fri);
            Console.WriteLine("ToDay Index = {0}", (int)Week.Sat);
            Console.WriteLine("ToDay Index = {0}", (int)Week.Sun);



        }
    }
}
