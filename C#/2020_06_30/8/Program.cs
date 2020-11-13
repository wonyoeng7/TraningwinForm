using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    using System;
    using System.Net.NetworkInformation;

    public class ParamRef
    {
        public int myVal = 10;
    }

    public class ParamTest
    {
        public static void Increase(ParamRef varRef)
        {
            varRef.myVal++;
        }
        public static void Main(string[] args)
        {
            ParamRef pr = new ParamRef();
            Console.WriteLine("호출 전 : {0}",pr.myVal);
            ParamTest.Increase(pr);
            Console.WriteLine("호출 후 : {0}", pr.myVal);
        }

    }
    

      
    
}
