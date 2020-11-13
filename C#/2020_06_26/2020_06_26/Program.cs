using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_26
{
    class Program
    {
        static void Main(string[] args)
        {

            //double radius = 3.14;

            //Console.WriteLine("radius의 형 : {0}", radius.GetType());     
            //Console.WriteLine("radius의 형 : {0}", radius.ToString());   
            //Console.WriteLine();

            //string name = "이효리";
            //Console.WriteLine("radius의 형 : {0}", name.GetType());
            //Console.WriteLine("radius의 형 : {0}", name.ToString());
            //Console.WriteLine();

            //Console.WriteLine("radius == name : {0}", name.Equals(radius));

            //int intValue = 127;
            //long longValue = intValue;

            //Console.WriteLine("longValue = {0}", longValue);


            //long longValue = 32767;
            //int intValue = (int)longValue;

            //Console.WriteLine("intValue = {0}", intValue);


            //int aint = 0x12345678;
            //Console.WriteLine("{0:X8}", aint);
            //aint = ~aint;
            //Console.WriteLine("{0:X8}", aint);
            //aint = aint >> 4;
            //Console.WriteLine("{0:X8}", aint);
            //aint = aint << 4;
            //Console.WriteLine("{0:X8}", aint);

            //byte abyte1 = 0x3F;
            //byte abyte2 = 0xC1;

            //Console.WriteLine("AND {0:X2}", abyte1 & abyte2);
            //Console.WriteLine("OR {0:X2}", abyte1 | abyte2);
            //Console.WriteLine("XOR {0:X2}", abyte1 ^ abyte2);


            ////Console.WriteLine("bool의 상태는" + (abool ? "참" : "거짓") + "일껄요?");

            //int iNum = 100;
            //if(iNum < 500)
            //{
            //    Console.WriteLine("iNum은 500보다 작습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("iNum은 500보다 큽니다.");
            //}

           int point = 60;
           string result;
            
            if (point >= 0 && point <= 100)
            {
                if (point > 50)
                {
                    result = "Pass";
                }               
                else
                {
                    result = "Fail";
                    
                }
                Console.WriteLine("결과 : " + result);
            }
            else
            {
                Console.WriteLine("에러 : 범위를 벗어났습니다.");
            }
        }
    }
}
