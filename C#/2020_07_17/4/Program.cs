using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Vehicle {}

    class Car : Vehicle {}

    class ConsoleApplication
    {

        static void Main(string[] args)

        {
            Vehicle aVehicle = new Vehicle();
            Car aCar = new Car();

           
            if(aVehicle is Car) //아님
            {
                aCar = (Car)aVehicle;
            }
            else
            {
                Console.WriteLine("aVehicle은 Car가 아입니더");
            }

        }  
    }
}





