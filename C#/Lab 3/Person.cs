using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Person
    {
        //инкапсуляция, поля(один стат. элемент класса)
        static int id = 100;

        //свойства
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public int RealId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }

        //перегрузка/методы
        public void Enter(string password)
        {
            if (password == "Output")
            {
                Console.WriteLine("Person id:" + RealId + "\nAge: " + Age + "\nHeight " + Height + " Weight " + Weight);
            }
        }

        public void Enter(int password)
        {
            if (password == 1)
            {
                Console.WriteLine("Person name: " + Name + " " + Surname + "\nAdress " + Adress);
            }
        }

        //конструктор
        public Person() : this(0, 0, 0, 0)
        {
        }
        public Person(int age, int height, int weight, int realId)
        {
            this.Age = age;
            this.Height = height;
            this.Height = weight;
            Person.id += 1;
            this.RealId = Person.id;
        }
    }
}


