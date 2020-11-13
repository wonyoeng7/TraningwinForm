using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myComputer = Dns.GetHostName();

            Console.WriteLine("컴퓨터 이름:" + myComputer);

            IPHostEntry entry = Dns.GetHostEntry(myComputer);
            foreach(IPAddress iPAddress in entry.AddressList)
            {
                Console.WriteLine(iPAddress.AddressFamily + ": " + iPAddress);
            }    
        }
    }
}
