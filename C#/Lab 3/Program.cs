using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People(5);

            people[0] = new Person { Age = 20, Height = 180, Weight = 80, Name = "Virus", Surname = "Corona", Adress = "Belarus" };

            people[0].Enter("Output");
            people[0].Enter(1);

            people[1] = new Person { Age = 10, Height = 210, Weight = 80, Name = "Creed", Surname = "Ner", Adress = "South africa" };

            people[1].Enter("Output");
            people[1].Enter(1);
        }
    }
}



