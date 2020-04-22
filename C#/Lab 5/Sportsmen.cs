using System;
using System.Collections.Generic;
using System.Text;

namespace Footballers
{
    abstract class Sportsmen : Person
    {
        public DateTime DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Sportsmen() : base()
        {
            DateOfBirth = new DateTime(1980, 03, 21);
            Height = 182;
            Weight = 76;
        }
        public Sportsmen(string s, string n, string c, DateTime dob, int w, int h) : base(s, n, c)
        {
            DateOfBirth = dob;
            Weight = w;
            Height = h;
        }
        public override string ToString() => base.ToString() + $"\nDate of birth: {DateOfBirth}\nWeight: {Weight}\tHeight: {Height}";
    }
}
