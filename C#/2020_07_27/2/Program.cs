using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);

        static int TestMethod(uint type)
        {
            return 0;
        }
        
        static void Main(string[] args)
        {
            MessageBeep(0);
        }
    }

}
