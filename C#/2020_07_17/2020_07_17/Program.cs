using System;

namespace _2020_07_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            double Num3;


            //Num1 = 100;
            //Num1 = int.Parse("100");

            //Console.WriteLine(Num1);
            //Console.WriteLine(Num2);

            //위에 Num1 = int.Parse(Console.ReadLine());과 동일하다 
            //string TempString;
            //TempString = Console.ReadLine();
            //iNum1 = int.Parse(TempString);


            while (true)
            {
                try
                {
                    Console.Write("첫번째 양수를 입력 : ");
                    Num1 = int.Parse(Console.ReadLine());
                    if(Num1 < 0)
                    {
                        Exception aException = new Exception();
                        throw aException;  //예외를 던진다 throw로 여기 밑으로는 실행되지 않는다. 

                    }
                    Console.Write("두번째로 입력할 숫자 : ");
                    Num2 = int.Parse(Console.ReadLine());

                    Num3 = Num1 / Num2;
                }


                catch (FormatException) 

                {                
                    Console.WriteLine("문자를 입력함");
                    continue;
                }

                catch (DivideByZeroException)

                {
                    Console.WriteLine("0으로 나눌수 없음");
                    continue;
                }

                catch (Exception)
                {
                    Console.WriteLine("음수를 입력했네");
                    continue;
                }

                finally
                {
                    Console.WriteLine("이건 예외가 있던 없던 무조건 거쳐 감");
                }
                break;
            }



        }
    }
}
