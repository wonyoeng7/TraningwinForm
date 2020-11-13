using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_28
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddr = IPAddress.Parse("202.179.177.21");
            Console.WriteLine(ipAddr);

            IPAddress ipAddr2 = new IPAddress(new byte[] { 202,179,177,21 });
            Console.WriteLine(ipAddr2);



        }
    }
}
