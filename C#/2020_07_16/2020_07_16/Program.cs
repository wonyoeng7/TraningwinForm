﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_07_16
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");

        }
    }
    
    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네 발로 움직인다.");

        }

    }

    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("수영한다.");

        }

    }

    class Human : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("두 발로 움직인다.");

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Mammal one = new Mammal(); ;
            //one.Move();

            //Lion lion = new Lion();
            //lion.Move();

            //Whale whale = new Whale();
            //whale.Move();

            //Human human = new Human();
            //human.Move();

            Lion lion = new Lion();
            Mammal one = lion;
            one.Move();
            Human human = new Human();
            Mammal two = human;
            two.Move();
        }
    }
}