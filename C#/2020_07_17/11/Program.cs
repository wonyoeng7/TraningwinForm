using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program1
    {

        private string[] _array;

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
        class Program
        {
            static void Main(string[] args)
            {
                testc aTest = new testc();

                aTest[0] = "할룽";
                //하다가 맘
            }
        }
    }
}
