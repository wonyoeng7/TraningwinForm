using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_30
{

    class A
    {
        public static void MethodA()   //메소드 왼쪽에 static을 붙이게 되면 객체를 생성없이 호출할수 있다.
                                                                         
        {
            System.Console.WriteLine("MethodA() in class A");

        }
    }
    class B
    {
        public static void Main(string[] args)
        {

            A.MethodA();
        }
    }
}
