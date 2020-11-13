using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @Struct
{   //struct에 대한 설명 class랑 비교하면서 설명한다.
    class Tclass
    {
        public int a;
        public int b;
        public string s;

        public override string ToString()
        {
            return "[" + a + "]" + "[" + b + "]" + "[" + s + "]";
        }
    }

    struct Tstruct
    {
        public int a;
        public int b;
        public string s;

        public Tstruct(int Temp)
        {
            a = 100;
            b = 200;
            s = Temp.ToString();
        }

        public override string ToString()
        {
            return "[" + a + "]" + "[" + b + "]" + "[" + s + "]";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tstruct aTstruct = new Tstruct();       //구조체는 값으로 만들어 진다. 왼쪽이랑 오른쪽이 같이 생성되고 
            aTstruct.a = 100;
            aTstruct.b = 101;
            aTstruct.s = "헬로";

            Console.WriteLine(aTstruct);

            Tstruct aTstruct1;    //구조체는 C#에만 있다. 객체 생성없이 쓸수 있다. 값을 입력해줘야 객체가 생성된다. Stack에 만든다. Stack은 변수값이 자동으로 초기화 되지 않는다.
            aTstruct1.a = 102;    //구조체는 스택에 생성 클래스는 힙영역에 생성
            aTstruct1.b = 103;
            aTstruct1.s = "헬로 키티";

            Console.WriteLine(aTstruct1);

            Console.WriteLine("=====================================");

            Tclass atclass = new Tclass();
            atclass.a = 100;
            atclass.b = 101;
            atclass.s = "헬로우";

            Console.WriteLine(atclass);

            Tclass atclass1 = new Tclass();
            atclass1.a = 101;
            atclass1.b = 102;
            atclass1.s = "헬로우 키티";

            Console.WriteLine(atclass1);

            Console.WriteLine("=====================================");

            atclass = atclass1;
            aTstruct = aTstruct1;

            Console.WriteLine(atclass);
            Console.WriteLine(atclass1);
            Console.WriteLine(aTstruct);
            Console.WriteLine(aTstruct1);

            Console.WriteLine("=====================================");

            aTstruct1.a = 500;
            atclass1.a = 500;
            Console.WriteLine(aTstruct);
            Console.WriteLine(aTstruct1);
            Console.WriteLine(atclass);
            Console.WriteLine(atclass1);

            int iNum = new int(); //== int iNum =0과 같다.
            ++iNum;
            Console.WriteLine(iNum);

            int iNum2;  //iNum2에는 쓰레기 값이 들어있다. stack영역이라서
            //++iNum2;    //iNum2에 1더하면 쓰레기다. 그래서 출력이 안된다.
            //Console.WriteLine(iNum2);

            //Tstruct.aTstruct = new Tstruct();
            Console.WriteLine(aTstruct);

            //Tstruct.aTstruct1 = new Tstruct(700);
            Console.WriteLine(aTstruct1);





        }
    }
}
