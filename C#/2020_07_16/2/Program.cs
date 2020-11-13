using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2
{
    abstract class Musician // 추상 클래스 : abstract 키워드에 의해 추상 클래스는 객체로서의 역할을 못한다.
    {
        public virtual void Name()
        {
            Console.WriteLine("Musician");
        }

        //public abstract void Instruments(); // 추상 메소드 : 추상 클래스 내부 선언
        public void Instruments()
        {
            
        }

    }

    class ViolinPlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("ViolinPlayer");
        }

        public void Instruments()
        {
            Console.WriteLine("Violin");
        }
    }



    class PianoPlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("PianoPlayer");
        }
        public void Instruments()
        {
            Console.WriteLine("Piano");

        }
    }
    class FlutePlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("FlutePlayer");
        }
        public void Instruments()
        {
            Console.WriteLine("Flute");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Musician[] Array = new Musician[3];
            Array[0] = new ViolinPlayer();
            Array[1] = new PianoPlayer();
            Array[2] = new FlutePlayer();

            for (int i = 0; i < Array.Length; ++i)
            {
                Array[i].Name();
                Array[i].Instruments();
                Console.WriteLine("**********");
            }

        }
    }
}
