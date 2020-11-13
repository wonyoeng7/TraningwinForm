using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_15
{
    class Parent
    {
        public int iNum;
        public Parent()
        {
            iNum = 100;
            Console.WriteLine("Parent 클래스 생성자");
        }
        public Parent(int iNum)
        {
            this.iNum = iNum;
            Console.WriteLine("Parent 클래스 생성자");
        }
        ~Parent()
        {
            Console.WriteLine("Parent 클래스 소멸자");
        }

    }

    class Child : Parent
    {

        public int iNum;

        public Child()  : base(101)    //원래는 이렇게 되어있는데 컴파일러가 base를 넣어서 호출한다.
        {
            iNum = 200;
            Console.WriteLine("Child 클래스 생성자");
        }
        public void Print()
        {
            Console.WriteLine("Parent 클래스 iNum" + base.iNum);   //상위 클라스로 가고 싶을때는 base를 사용하면 된다. 
            Console.WriteLine("Child 클래스 iNum" + this.iNum);
        }
        ~Child()
        {
            Console.WriteLine("Child 클래스 소멸자");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child aChild = new Child();
            aChild.Print();


        }
    }
}
