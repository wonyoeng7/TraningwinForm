using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class TestInt
    {

        private int[] _array;
        public TestInt(int Size)
        {
            _array = new int[Size];
        }

        public int this[int Index]          
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

        static void Main(string[] args)
        {
            TestInt aTestInt1 = new TestInt(10);    //10
            TestInt aTestInt2 = new TestInt(20);    //20

        }
    }


}
