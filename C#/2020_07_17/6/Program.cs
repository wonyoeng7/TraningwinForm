using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Vehicle { }

    class Car : Vehicle { }

    class ConsoleApplication
    {

        static void Main(string[] args)

        {
            Vehicle aVehicle = new Car();
            Car aCar = new Car();

            aCar = aVehicle as Car;  // as 왼쪽에 있는 애가 오른쪽에 있는게 있나 물어봄 없으면 null값을 넣어줌

            if (aCar == null)
            {
                Console.WriteLine("널 보내줄께");
            }
            else
            {
                Console.WriteLine(aCar);
            }

        }
    }
}
