using System;
using System.Collections.Generic;
using System.Text;

namespace Footballers
{
    class Footballer : Sportsmen
    {
        public Position @Position { get; set; }
        public struct Quality
        {
            public int fifaRate;
            public int maxCoast;
        }
        public Quality tmp;
        public Footballer() : base()
        {
            @Position = Footballers.Position.LeftWinger;
            tmp.fifaRate = 95;
            tmp.maxCoast = 80000000;
        }
        public Footballer(string s, string n, string c, DateTime dob, int w, int h, Position p, int fr, int mc) : base(s, n, c, dob, w, h)
        {
            @Position = p;
            tmp.fifaRate = fr;
            tmp.maxCoast = mc;
        }
        public override string ToString() => base.ToString() + $"\nPosition: {@Position}\nQuality:\nFifa rating: {tmp.fifaRate}\nMaximal coast: {tmp.maxCoast}\n";
    }
}
