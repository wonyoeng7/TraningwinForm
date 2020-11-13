using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Parent
    {
        public virtual void Name()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        public override void Name()         //public new void Name()라고 쓰게 되면 위에 있는 것과 상관이 없는 새로운 것을 사용한다.
                                            //아무것도 안쓰게 되면 컴파일러가 new로 간주한다. 
                                            //opublic override void Name()은 부모것을 새로 만들어 쓰게 될떄에는 override을 사용한다
                                            //둘중 new와 override와 같이 사용한다.
        {
            Console.WriteLine("Child");
        }
    }

    class GrandChild : Child
    {
        public override void Name()
        {
            Console.WriteLine("GrandChild");
        }
    }
    class ConsoleApplication
    {
        public static void Main(string[] args)
        {
            //Parent obj1 = new Parent();
            //Parent obj2 = new Child();
            //Parent obj3 = new GrandChild();

            //obj1.Name();
            //obj2.Name();
            //obj3.Name();

            Parent[] Array = new Parent[] {    new Parent(),
                                               new Child(), 
                                               new GrandChild(),
                                               new GrandChild(),
                                               new Child()
                                           };

            for (int i = 0; i < Array.Length; ++i)
            {
                Array[i].Name();
            }
        }
    }
}
