using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7

{
    class Vehicle { }

    class Car : Vehicle { }

    class ConsoleApplication
    {

        static void Main(string[] args)

        {
            Object[] aObject = new Object[] { new Vehicle(),
                                              new Car(),
                                              new Vehicle(),
                                              new Car(),
                                              new Vehicle(),
                                              new Vehicle(),
            };
            Car aCar;
            //Object[]안에 어떤 객체가 들어있는지 확인 하는 for문이다.
            for (int i = 0; i < aObject.Length; ++i) 
            {
                if((aCar = aObject[i] as Car) == null)
                {   //aCar가 Vehicle 객체인 경우
                    Vehicle avehicle = (Vehicle)aObject[i];
                    Console.WriteLine("Vehicle 타입");

                }
                else
                {   //aCar가 Car 객체인 경우
                    Console.WriteLine("Car 타입");
                }
            }



   

        }
    }
}
