using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement axElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            var XMLData = from Temp in axElement.Descendants("data")
                          select new Weather
                          {
                              Hour = Temp.Element("hour").Value,
                              Temp = Temp.Element("temp").Value,
                              Wfkor = Temp.Element("wfKor").Value,
                              Wdkor = Temp.Element("wdKor").Value,

                          };

            foreach (var Temp in XMLData)
            {
                Console.WriteLine(Temp);
            } 

            //foreach (var Temp in XMLData)
            //{
            //    Console.Write(Temp.Element("hour").Value + "시\t\t");
            //    Console.Write(Temp.Element("temp").Value + "℃\t\t");
            //    Console.Write(Temp.Element("wfKor").Value + "\t\t");
            //    Console.Write(Temp.Element("wdKor").Value + "풍\t\t");
            //    Console.WriteLine();
            //}
        }
    }
}
