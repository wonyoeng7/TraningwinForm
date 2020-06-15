using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace GENERICAPP
{
    public class SimpleGeneric<T>
    {
        private T[] valuse;
        private int index;

        public SimpleGeneric(int len)
        {
            valuse = new T[len];
            index = 0;
        }

        public void Add(params T[] args)
        {
            foreach (var item in args)
            {
                valuse[index++] = item;
            }
        }

        public void Print()
        {
            foreach (T item in valuse)
            {
                Console.WriteLine(item +", ");
            }
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<int> gIntegers = new SimpleGeneric<int>(10);
            SimpleGeneric<double> gDoubles = new SimpleGeneric<double>(10);

            gIntegers.Add(1, 2);
            gIntegers.Add(1, 2, 3, 4, 5, 6, 7);
            gIntegers.Add(10);

            gDoubles.Add(10.0, 12.4, 37.5);
            gIntegers.Print();
            gDoubles.Print();
        }
    }
}
