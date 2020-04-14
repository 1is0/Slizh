using System;
using System.Collections.Generic;
using System.Text;

namespace Footballers
{
    abstract class Sportsmen : Person
    {
        public string DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Sportsmen() : base()
        {
            DateOfBirth = "21.03.1980";
            Height = 182;
            Weight = 76;
        }
        public Sportsmen(string s, string n, string c, string dob, int w, int h) : base(s, n, c)
        {
            DateOfBirth = dob;
            Weight = w;
            Height = h;
        }
        public override string ToString() => base.ToString() + $"\nDate of birth: {DateOfBirth}\nWeight: {Weight}\tHeight: {Height}";
    }
}
