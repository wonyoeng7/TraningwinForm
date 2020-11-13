using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    using System;
    public class ParamValue
    {
        public void Increase(int n)
        {
            n++;
        }
        
        public static void Main(string[] args)
        {
            int i = 10;
            ParamValue pv = new ParamValue();
            Console.WriteLine("호출 전 : {0}", i);
            pv.Increase(i);
            Console.WriteLine("호출 후 : {0}", i);
        }
    
    }

}
