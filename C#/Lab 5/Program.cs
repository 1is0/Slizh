using System;
using System.Collections.Generic;
using System.Text;

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
    class Program
    {
        public static Footballer EnterPlayer()
        {
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter date of birth:");
            string date = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            int weight = CheckNaturalNumber();
            Console.WriteLine("Enter Height:");
            int height = CheckNaturalNumber();
            OutputOfEnum();
            int position = CheckPosition();
            Console.WriteLine("Enter FIFA rating[1,99]:");
            int fifaRate = CheckFifaRating();
            Console.WriteLine("Enter maximal coast of player:");
            int coast = CheckNaturalNumber();
            return new Footballer(surname, name, country,date, weight, height, (Position)position, fifaRate, coast);
        }
        public static int CheckFifaRating()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0 || a>=100)
                Console.Write("Incorrect input, repeat: ");
            return a;
        }
        public static int CheckNaturalNumber()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write("Incorrect input, repeat: ");
            return a;
        }
        public static void OutputOfEnum()
        {
            Console.WriteLine("Enter player's position");
            Console.WriteLine("1 - Goalkeeper\n2 - Right defender\n3 - Central defender\n4 - Left defender");
            Console.WriteLine("5 - Right Midfielder\n6 - Central Midfielder\n7 - Left Midfielder");
            Console.WriteLine("8 - Right winger\n9 - Central forward\n10 - Left winger");
        }
        public static int CheckPosition()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1 || a > 10)
                Console.Write("Incorrect input, repeat: ");
            return a;

        }
        public static void MakingArrayOfFootbalists(Footballer[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = EnterPlayer();
            Console.Clear();
            Console.WriteLine("Footballers:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
        static void Main(string[] args)
        {
            Footballer first = new Footballer();
            Footballer second = new Footballer("Rooney","Wayne","England","24.10.1985",80,176,Position.CentralForward,91,65000000);
            var third = EnterPlayer();
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Footballer[] arr = new Footballer[2];
            MakingArrayOfFootbalists(arr);
        }

    }        
    
}
