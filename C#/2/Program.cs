using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        class Car
        {
            const int iNum1 = 10;   //const을 쓰면 값을 넣어줘야 한다. 수정여지 없음
            readonly int iNUm2;     // 초반에 바꿀수 있는 여지가 있다.

            string _color;
            string _vender;
            string _name;
            //프로퍼티
            public string name
            {
                get
                {
                    return _name;
                }
                set
                {
                    value = "Auto:" + value;
                    this._name = value;
                }
            }

            public string GetName()
            {
                return _name;
            }

            public void SetName(string name)
            {
                name = "Auto:" + name ;
                this._name = name;
            }

            public void Print()
            {
                Console.WriteLine("{{[{0}]}},{{[{1}]}},{{[{2}]}}", _name, _vender, _color);
            }

            /* 생성자
             * 1. 메소드다
             * 2. 클래스와 이름이 동일
             * 3. 반환 타입이 존재하지 않는다.
             */
            public Car()    // 디폴트 생성자 : 인자가 없는 생성자
            {
                Console.WriteLine("Car 디폴트 생성자 호출");
            }

            public Car(string name)  : this(name,"미입력","미입력")   // 내말고 this를 호출하라는 뜻이다. 안에 3개가 들어있으면 밑에 3개를 호출
                                                               // 코드의 중복을 제거할수 있다.
                                                               // 초기화 목록
            {
                //this.name = name;       //현재 실행되는 객체를 부를때 사용 this
                //Console.WriteLine("Car 생성자 호출");
            }
            public Car(string name, string vender) : this(name, vender,"미입력") //초기화 목록
            {
                //this.name = name;
                //this.vender = vender;
                //Console.WriteLine("Car 생성자 호출");
            }

            public Car(string name, string vender, string color)
            {
                iNUm2 = 100;
                this._name = name;
                this._vender = vender;
                this._color = color;
                Console.WriteLine("Car 생성자 호출");
            }

            ~Car()  //소멸자
            {
                Console.WriteLine("Car 소멸자 호출");
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("1.=================================");
            Car acar = new Car("비앰다블유");  //new 다음에는 해당하는 생성자의 객체를 넣는다. 위에 public Car()에서 public이여야만 사용이 가능하다.
            //aCar.Car(); 생성자는 객체를 만들때 한번만 실행된다.
            new Car();  //임시 객체(일회용 객체)
            Console.WriteLine("2.=================================");
            acar.Print();
            acar.SetName("비안츠");
            acar.Print();
            string name = acar.GetName();
            Console.WriteLine("읽어온 값은 : " + name);

            Console.WriteLine("3.=================================");
            acar.SetName("람보르니");
            acar.name = "람보르니";
            acar.Print();
            name = acar.name;
            Console.WriteLine("읽어온 값은 : " + name);
            Console.WriteLine("4.=================================");


        }

    }
}
