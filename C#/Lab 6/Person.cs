using System;
using System.Collections.Generic;
using System.Text;

namespace Footballers
{
    abstract class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Person()
        {
            Name = "Ronaldinho";
            Surname = "de Assis Moreira";
            Country = "Brazil";
        }
        public Person(string s, string n, string c)
        {
            Surname = s;
            Name = n;
            Country = c;
        }
        public override string ToString() => $"Name: {Name}\t Surname: {Surname}\nCountry: {Country}";
    }
}