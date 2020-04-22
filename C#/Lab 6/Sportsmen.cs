using System;

namespace Footballers
{
    enum Position
    {
        Goalkeeper = 1,
        RightDefender,
        CentralDefender,
        LeftDefender,
        RightMidfielder,
        CentralMidfielder,
        LeftMidfielder,
        RightWinger,
        CentralForward,
        LeftWinger
    }
    abstract class Sportsmen : Person
    {

        public DateTime DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public double Salary { get; set; }
        public Sportsmen() : base()
        {
            DateOfBirth = new DateTime(1980, 03, 21);
            Height = 182;
            Weight = 76;
            Salary = 50000;
        }
        public Sportsmen(string s, string n, string c, DateTime dob, int w, int h, double sal) : base(s, n, c)
        {
            DateOfBirth = dob;
            Weight = w;
            Height = h;
            Salary = sal;
        }
        public override string ToString() => base.ToString() + $"\nDate of birth: {DateOfBirth}\nWeight: {Weight}\tHeight: {Height}\nSalary: {Salary}";
    }
}
