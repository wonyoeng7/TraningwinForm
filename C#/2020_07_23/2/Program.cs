using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{

    class Program
    {
        delegate int NewType(int Num);  //위임, 대리자, 별칭같은 느낌


        static int OnePlus(int Num)
        {
            return Num + 1;
        }

        static int TenPlus(int Num)
        {
            return Num + 10;
        }

        static void Main(string[] args)
        {
            int TestNum = OnePlus(100);
            Console.WriteLine(TestNum);

            NewType aNewType = new NewType(OnePlus);
            TestNum = aNewType(1000);
            Console.WriteLine(TestNum);

            aNewType = new NewType(TenPlus);
            TestNum = aNewType(1000);
            Console.WriteLine(TestNum);
        }
    }
}
