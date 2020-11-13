using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_13
{
    class Program
    {

        static int ADD(int  N1, int N2)
        {
            Console.WriteLine("저는 int형 입니다.");
            return N1 + N2;
        }

        static double ADD(double N1,double N2)      
        {
            Console.WriteLine("저는 double형 입니다.");
            return N1 + N2;
        }

        static float ADD(float N1, float N2)
        {
            Console.WriteLine("저는 float형 입니다.");
           
            return N1 + N2;
        }



        static void Main(string[] args)
        {
            ADD(1, 2);
            ADD(1.0, 2.0);
            ADD(1.0f, 2.0f);

            // 매소드의 결과 값을 변수에 저장해서 활용하는 경우
            int iNum = ADD(1, 2);
            Console.WriteLine(iNum);

            // 메소드의 결과 값을 저장하지 않고 활용하는 경우
            if (3 ==ADD(1,2))
            {
                Console.WriteLine("결과는 3입니다.");
            }

        }



    }
}
