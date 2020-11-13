using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int CalcDelegate(int x, int y);

class MessageMap
{
    public char opCode;
    public CalcDelegate Calc;

    public MessageMap(char opCode, CalcDelegate Calc)
    {
        this.opCode = opCode;
        this.Calc = Calc;

    }
}
public class Mathematics
    {
        
        MessageMap[] aMessageMap;
        
        static int Add(int x, int y) { return x + y; }
        static int Subtract(int x, int y) { return x - y; }
        static int Multiply(int x, int y) { return x * y; }
        static int Divide(int x, int y) { return x / y; }
        static int Per(int x, int y) { return x % y; }


    public Mathematics()
        {
           
            aMessageMap = new MessageMap[] {
                new MessageMap('+', Add),
                new MessageMap('-', Subtract),
                new MessageMap('*', Multiply),
                new MessageMap('/', Divide),
                new MessageMap('%', Per)
            };
        }

        public void Calculate(char opCode, int operand1, int operand2)
        {
        
            Console.Write(opCode + " : ");
            foreach (MessageMap Temp in aMessageMap)
            {
                if (Temp.opCode == opCode)
                {
                    Console.WriteLine(Temp.Calc(operand1, operand2));
                }

            }


        }
    }


namespace ConsoleApp1
{
    class Program
    {
        delegate void WorkDelegate(char arg1, int arg2, int arg3);


        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            WorkDelegate  Work= math.Calculate;

            Work('+', 10, 5);
            Work('-', 10, 5);
            Work('*', 10, 5);
            Work('/', 10, 5);
            Work('%', 10, 5);
        }
    }
}
