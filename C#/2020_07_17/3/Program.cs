using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace _3
    {
        class Vehicle{}
  
        class Car : Vehicle{}

        class ConsoleApplication
        {   

        static void Main1(string[] args)
            {

                Vehicle vehicle = new Vehicle();
                Car car = new Car();

                Vehicle a = car;    //형변환 : 묵시적/암시적/자동
                Car b = (Car)a;     //형변환 : 명시적/강제적




            }
        }
}
