using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2020_09_14_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement aXElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            //Console.WriteLine(aXElement);
            var XMLData = from Temp in aXElement.Descendants("data")
                          select new Weather()
                          {
                              Hour = Temp.Elements("hour").Value,
                              Temp = Temp.Elements("temp").Value,
                              WfKor = Temp.Elements("wfKor").Value,
                              WdKor = Temp.Elements("WdKor").Value,

                          };

            foreach (var Temp in XMLData)
            {
                Console.WriteLine(Temp);
            }

        }
    }
}
