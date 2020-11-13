using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Example
    {
        public static int classvari1 = 0 ;  //클래스에는 항상 메모리를 초기화 시켜놓고 자료를 넣기 때문에 아무것도 넣지 않으면 0이 들어가 있다.
       
        public int classvari2 = 0;

        public Example()
        {
            classvari1++;
            classvari2++;
        }

        public void Print()
        {
            Console.WriteLine("Classvari1 : " + classvari1);
            Console.WriteLine("Classvari2 : " + classvari2);
        }


        public static void Main(string[] args)
        {
            Example e1;     //지역변수이기에 자료를 입력하지 않으면 쓰레기 값이 들어간다.
            Example e2;
            e1 = new Example();  //객체를 생성
            e1.Print();

            e2 = new Example();
            e2.Print();

            e1.Print();
        }
    }
    
}
