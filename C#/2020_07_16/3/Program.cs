using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    interface test  //추상메소드만 보유할수 있는 interface
    {
        //int iNum;
        //void tt()
        //{}
        void tt();

    }

    class Auto : test
    {
        public void tt()
        {

        }
    }

    interface IMusicion
    {
        void Name();
    }

    class PianoPlayer : IMusicion
    {
        public void Name()
        {
            Console.WriteLine("PianoPlayer");
        }
    }

    interface IMusicion
    {
        void Singing();
    }

    interface IActor
    {
        void Playing();
    }

    class Musical : IMusicion, IActor
    {
        public void Singing()
        {
            Console.WriteLine("노래하다");
        }

        public void Playing()
        {
            Console.WriteLine("연기하다");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
                Musical aMusical = new Musical();
                aMusical.Playing();
                aMusical.Singing();
        }
    }
}
