using System;

namespace Footballers
{
    class Program
    {
        public static Footballer EnterPlayer()
        {
            Console.WriteLine("Creating of a new player");
            Footballer player = new Footballer();
            Console.WriteLine("Enter surname:");
            player.Surname = Console.ReadLine();
            Console.WriteLine("Enter name:");
            player.Name = Console.ReadLine();
            Console.WriteLine("Enter country:");
            player.Country = Console.ReadLine();
            Console.WriteLine("Enter date of birth:");
            //DateTime date = CheckDate();
            player.DateOfBirth = CheckDate();
            Console.WriteLine("Enter Weight:");
            player.Weight = CheckNaturalNumber();
            Console.WriteLine("Enter Height:");
            player.Height = CheckNaturalNumber();
            Console.WriteLine("Enter a salary of footballer:");
            player.Salary = CheckNaturalNumber();
            OutputOfEnum();
            player.Position = (Position)CheckPosition();
            Console.WriteLine("Enter FIFA rating[1,99]:");
            player.qual.fifaRate = CheckFifaRating();
            Console.WriteLine("Enter maximal coast of player:");
            player.qual.maxCoast = CheckNaturalNumber();
            Console.WriteLine("Do u want to send a footballer on carantine?\n1 - Yes\t0 - No\n(salary -70%)");
            int temp = YesNoCheck();
            if (temp == 1)
            {
                player.Carantine(player.Salary);
            }
            Console.WriteLine("Do u want to give a nickname for a footballer?\n1 - Yes\t0 - No");
            int nick = YesNoCheck();
            if (nick == 1)
            {
                Console.WriteLine("Enter a nickname of footballer(name and surname will be changed)");
                player.Nickname();
                return player;
            }
            else return player;


            //return new Footballer(surname, name, country, date, weight, height, salary, (Position)position, fifaRate, coast);
        }
        public static DateTime CheckDate()
        {
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
                Console.Write("Incorrect input, enter date again: ");
            return date;
        }
        public static int CheckFifaRating()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0 || a >= 100)
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
        public static int YesNoCheck()
        {
            int tmp;
            while (!int.TryParse(Console.ReadLine(), out tmp) || tmp < 0 || tmp > 1)
                Console.Write("Incorrect input, repeat: ");
            return tmp;
        }
      /*  static void Coping()
        {
            Console.WriteLine("Enter which player do u want to copy:");
            int cpy = Convert.ToInt32(Console.ReadLine());
            if ()
        }*/
        static void Main(string[] args)
        {
            bool flag = false;
            Footballer first = new Footballer();
            Footballer second = new Footballer("Rooney", "Wayne", "England", new DateTime(1985, 10, 24), 80, 176, 100000, Position.CentralForward, 91, 65000000);
            var third = EnterPlayer();
            Console.Clear();
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine("=>Press enter");
            Console.ReadLine();
            Console.Clear();
            Footballer[] arr = new Footballer[2];
            MakingArrayOfFootbalists(arr);
            Console.WriteLine("=>Press enter");
            Console.ReadLine();
            Console.Beep();
            Console.Clear();
            while (flag != true)
            {
                Console.WriteLine("Enter which player do u want to copy:");
                int cpy = Convert.ToInt32(Console.ReadLine());
                if (cpy < arr.Length + 1)
                {
                    Footballer player = (Footballer)arr[cpy - 1].Clone();
                    Console.WriteLine("Copied player:");
                    Console.WriteLine(player);
                    flag = true;
                }
                else Console.WriteLine("Player not exists, Enter existing player!");
            }
            Console.WriteLine("=>Press enter");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Array of footballers, sorted by coast, using IComparer");
            Array.Sort(arr, new Footballer());
            foreach (Footballer f in arr)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("=>Press enter");
            Console.ReadLine();
        }

    }

}