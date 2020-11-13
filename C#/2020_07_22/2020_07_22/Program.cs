using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class TestInt
    {

        private int[] _array = new int[6];      //6개 짜리 배열

        public int this[int Index]          //인덱서 Indexer
        {
            get     //가져갈때
            {
                return _array[Index];

            }
            set     //대입
            {
                _array[Index] = value;
            }
        }
    }

    class Test
    {

        private string[] _array = new string[5];

        public string this[int Index]
        {
            get
            {
                return _array[Index];

            }
            set
            {
                _array[Index] = value;
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Test aTest = new Test();
                TestInt aTestInt = new TestInt();

                aTest[0] = "할룽a";   
                aTest[1] = "할룽b";
                aTest[2] = "할룽c";
                aTest[3] = "할룽d";
                aTest[4] = "할룽e";
               
                Console.WriteLine(aTest[2]);

                aTestInt[0] = 1;
                aTestInt[1] = 2;
                aTestInt[2] = 3;
                aTestInt[3] = 4;
                aTestInt[4] = 5;
                aTestInt[5] = 6;

                Console.WriteLine(aTestInt[5]);

        }
    }
    
}
