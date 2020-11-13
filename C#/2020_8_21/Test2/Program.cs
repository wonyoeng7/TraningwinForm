using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {

        class Fact : IComparable
        {
            public string Name;
            public int Age;
            public string Gender;

            public int CompareTo(object obj)
            {

                Fact aFact = (Fact)obj;
                return this.Age.CompareTo(aFact.Age);
                //return Age.CompareTo(((Fact)obj).Age); ;
                //throw new NotImplementedException(); //이것을 반드시 지우고 써라.
            }

            public override string ToString()
            {
                return string.Format($"{Name}, {Age}, {Gender} ");
            }

        }
        static void Main(string[] args)
        {
            List<Fact> aList = new List<Fact>();
            Fact Temp = new Fact();
            Temp.Name = "그놈";
            Temp.Age = 20;
            Temp.Gender = "남";
            aList.Add(Temp);
            //Console.WriteLine(Temp);

            aList.Add(Temp);
            Temp = new Fact();
            Temp.Name = "그녀";
            Temp.Age = 19;
            Temp.Gender = "여";
            aList.Add(Temp);
            //Console.WriteLine(Temp);

            //Temp = aList[1];
            Temp = aList[0];
            //Console.WriteLine(Temp);

            foreach (var vTemp in aList)
            {
                Console.WriteLine(vTemp);
            }
            aList.Sort();

            foreach (var vTemp in aList)
            {
                Console.WriteLine(vTemp);
            }

        }
    }
}
