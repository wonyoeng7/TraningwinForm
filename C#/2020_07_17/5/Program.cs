using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Vehicle { }

    class Car : Vehicle { }

    class ConsoleApplication
    {

        static void Main(string[] args)

        {
            Vehicle[] array = new Vehicle[] {new Car(),
                                             new Car(),
                                             new Vehicle()
                                            };
            for (int i = 0; i < array.Length; ++i)
            {
                Car aCar = (Car)array[i];
                Console.WriteLine(array[i]);     
            }
           
        }
    }
}
