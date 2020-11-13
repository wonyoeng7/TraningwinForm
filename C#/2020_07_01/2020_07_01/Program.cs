using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_01
{
    using System;
    public class ParamValue
    {
        public void Increase(out int n)
        {
            n = 11;
        }
    
        public static void Main(string[] args)
        {
            int i = 9;
            ParamValue pv = new ParamValue();
            pv.Increase(out i);
            Console.WriteLine("호출후 값 : {0} ", i);
        }
    }
}
