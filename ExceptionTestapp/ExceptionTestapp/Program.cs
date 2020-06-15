using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100,y = 5, value= 0;
           
            try   //에러 날 부분을 넣는다.
            {
                value = x / y;
                Console.WriteLine($"{x} / {y} = {value}");
                throw new Exception(" 사용자 에러");
                //위에 꺼와 같다.Console.WriteLine($"{0} / {1} = {2}",x,y,value);

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("2. y의 값을 0보다 크게 입력하세요.");
            }
            catch (Exception ex)    //exceoption은 finally 바로 위에 있어야 한다.
            {
                Console.WriteLine("3. " + ex.Message);                       
            }
            finally //에러가 나든 안나든 실행되는 구문
            {
                Console.WriteLine("4. 프로그램이 종료되었습니다.");
            }

        }
    }
}
