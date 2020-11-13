using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Form1
{
    class Program
    {
        static int addInt(int Num1, int Num2)   // 이 첫줄을 인터페이스(시그니처)라 한다.
        {
            return Num1 + Num2;
        }

        static int mulInt(int Temp1, int Temp2)
        { 
            return Temp1 * Temp2;
        }

        delegate int Facto(int Num1, int Num2);         // aFacto 와 addInt는 같은 자료형이라는 것이다.



        static void Main(string[] args)
        {
            int sum = addInt(3, 4);

            Console.WriteLine(sum);

            Facto aFacto = addInt;


            aFacto = addInt;    //aFacto는 딜리게이트인데 역할이 변할수 있다.즉 변수가 된다 덧셈 곱셈을 사용가능하다. addInt는 딜리게이트이지만 상수이다. 변하지 않는다.
            sum = aFacto(3, 4);
            Console.WriteLine(sum);

            aFacto = mulInt;
            sum = aFacto(3, 4);
            Console.WriteLine(sum);
        }
    }
}
