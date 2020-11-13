using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlainText = "할룽";
            char[] PlainTextArray = PlainText.ToCharArray();
            char Key = (char)0x0908;
            string CyperText;
            char[] CyperTextArray;

            CyperTextArray = new char[PlainTextArray.Length];
            CyperTextArray[0] = (char)(PlainTextArray[0] ^ Key);
            CyperTextArray[1] = (char)(PlainTextArray[1] ^ Key);

            CyperText = CyperTextArray.ToString();

            Console.WriteLine("PlainText : {0}{1}", PlainTextArray[0],PlainTextArray[1]);
            Console.WriteLine("CyperText : {0}{1}", CyperTextArray[0], CyperTextArray[1]);

            char[] PlainTextArray2 = new char[CyperTextArray.Length];
            PlainTextArray2[0] = (char)(CyperTextArray[0] ^ Key);
            PlainTextArray2[1] = (char)(CyperTextArray[1] ^ Key);

            Console.WriteLine("PlainTextArray2 : {0}{1}", PlainTextArray2[0], PlainTextArray2[1]);




        }
    }
}
