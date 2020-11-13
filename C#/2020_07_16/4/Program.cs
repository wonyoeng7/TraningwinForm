using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _4
{

    class Engin
    {
        string name;
        string vender;
        
        public Engin()
        {
            name = "휘발류 V6";
            vender = "비엔츠";
        }

        public override string ToString()
        {
            string temp = "[" + "{" + name + "}" + "{" + vender + "}" + "]";

            return temp;
        }

    }

    class Car : Object  // class Car은 옆에 class Car : Object을 붙이고 있다. Object은 최상의 메소드이다. 

    {
        string color;
        string name;
        string vender;
        Engin aEngin;

        public Car()
        {
            color ="red";
            name = "K5";
            vender = "기아";
            aEngin = new Engin();
        }

        public override string ToString()
        {
            string Temp = "[" + "{" + color + "}" + "{" + name + "}" + "{" + vender + "}" + "{" + aEngin + "}" + "]";

            return Temp;
        }
         
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car aCar = new Car();
            Console.WriteLine(aCar.Equals("test"));
            Console.WriteLine(aCar.GetHashCode());
            Console.WriteLine(aCar.GetType());
            Console.WriteLine(aCar.ToString());
            Console.WriteLine(aCar); //aCar.ToString()이 생략되었다고 여긴다. 컴파일러가
            



        }
    }
}
