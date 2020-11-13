using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class ParamValue
    {
        public static void ValMethod(params object[] arr)       //object는 최상의 타입이기에 모든것을 받을수 있다.
        {
            Console.WriteLine("[가변 인자 개수]   : " + arr.Length); //arr.Length뒤에 Tostring이 붙어야 하는데 안붙으면 자동으로 붙인다.

            Console.WriteLine("[인자 전체]  :");
            foreach(object one in arr)
            {
                Console.WriteLine(one + " "); //one.Tostring()이 생략해서 사용한다.

            }
            Console.WriteLine();

            Console.WriteLine("[문자열 타입]: ");
            for( int i = 0; i <arr.Length; i++)
            {
                Type t = arr[i].GetType();  //getType() 타입을 추출한다.
                if (t.Equals(typeof(System.String)))    //Equals은 bool형이다. typeof()은 예약어이다. typeof()의 ()안에 있는 타입을 가져온다.
                {
                    Console.Write(arr[i] + " ");        // String = System.String  같은거고 int = System.Int32이다.
                }
                
            }
            Console.WriteLine();


            Console.Write("[정수 타입]: ");
            foreach(object one in  arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Int32)))
                {
                    Console.Write(one + " ");
                }
                
            }
            Console.WriteLine();

            Console.Write("[DOUBLE형 타입]: ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(double)))   //double = System.Double을 넣어도 된다. 둘중에 하나 
                {
                    Console.Write(one + " ");
                }

            }
            Console.WriteLine();

            Console.Write("[Float형 타입]: ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(float)))  // float = System.single을 넣어도 된다. 둘중에 하나
                {
                    Console.Write(one + " ");
                }

            }
            Console.WriteLine();


        }
        static void Main(string[] args)
        {
            ValMethod(1000, 2000, "3000", "헬로", 3.1, 3.2f); //아무것도 안붙인 3.1은 double형이고 붙은거는 3.2f는 float형이다.
        }
    }
}
