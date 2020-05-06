using System;
using System.Threading;
using System.Collections.Generic;

namespace Footballers
{
    class Footballer : Sportsmen, IFootballers, ICloneable, IComparer<Footballer>
    {
        public Position @Position { get; set; }
        public int Distance { get; set; }
        public struct Quality
        {
            public int fifaRate;
            public int maxCoast;
        }
        public Quality qual;
        public Footballer() : base()
        {
            @Position = Footballers.Position.LeftWinger;
            qual.fifaRate = 95;
            qual.maxCoast = 80000000;
        }
        public Footballer(string s, string n, string c, DateTime dob, int w, int h, double sal, Position p, int fr, int mc) : base(s, n, c, dob, w, h, sal)
        {
            @Position = p;
            qual.fifaRate = fr;
            qual.maxCoast = mc;
        }
        public override string ToString() => base.ToString() + $"\nPosition: {@Position}\nQuality:\nFifa rating: {qual.fifaRate}\nMaximal coast: {qual.maxCoast}\n";
        public void Carantine(double salary)
        {
            Salary = salary*0.3;
        }
        public void Nickname()
        {
            Name = Surname = Console.ReadLine();
        }

        public delegate void Train();

        public event Train EndWork;

        public void Training()
        {
            Distance = 0;
            for (int i = 0; i < 10; i++)
            {
                Distance += 50;
                Thread.Sleep(2000);
                Console.WriteLine(Name + Surname + "is running" + Distance + "meters");
                Console.WriteLine("Now his weight is "+ Weight--);
                Console.WriteLine("Now his fifarate is " + qual.fifaRate++);
            }
            EndWork?.Invoke();
        }

        public object Clone() => (Footballer)this.MemberwiseClone();

        public int Compare(Footballer p1, Footballer p2)
        {
            if (p1.qual.maxCoast > p2.qual.maxCoast)
                return 1;
            else if (p1.qual.maxCoast > p2.qual.maxCoast)
                return -1;
            else
                return 0;
        }
    }
}