using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    using System;
    using System.Runtime.InteropServices;

    public class VariableLength
    {
        public int VarMethod(params int[] arr)
        {
            int sum = 0 ;
            for (int i = 0; i <arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            return sum;

        }
        public static void Main(string[] args)
        {
            int result;
            VariableLength vl = new VariableLength();
            result = vl.VarMethod(10, 20);
            Console.WriteLine(result);
            result = vl.VarMethod(1, 2, 3, 4);
            Console.WriteLine(result);
        }
    }
}
