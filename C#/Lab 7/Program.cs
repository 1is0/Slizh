using System;

namespace Lab7
{
    class Program
    {
        public static double GetDouble()
        {

            double tmp;

            while (!double.TryParse(Console.ReadLine(), out tmp))
            {
                Console.Write("Incorrect input, repeat: ");
            }

            return tmp;
        }

        public static Number GettingFractionalNumber()
        {
            Console.Write("\nEnter fractional number(in x/y format): ");

            string tempString = Console.ReadLine();
            while (!CheckFractionalNumber(tempString))
            {

                Console.Write("Incorrect input, repeat: ");
                tempString = Console.ReadLine();
            }

            try
            {
                string[] mas = tempString.Split('/');
                return new Number(int.Parse(mas[0]), int.Parse(mas[1]));
            }

            catch
            {
                return new Number(int.Parse(tempString), 1);
            }
        }

        public static Number GetNumber()
        {
            Console.Write("\nEnter natural number: ");
            double number = GetDouble();
            return new Number(number);
        }

        public static Number GettingRationalNumber()
        {
            int x;
            Console.Write("Press 1 to enter fractional number, 2 to enter natural number ");


            while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > 2)
            {
                Console.Write("Incorrect input, repeat: ");
            }

            if (x == 1)
            {
                return GettingFractionalNumber();
            }

            else
            {
                return GetNumber();
            }
        }

        public static bool CheckFractionalNumber(string frac)
        {
            if (String.IsNullOrEmpty(frac))
            {
                return false;
            }

            for (int i = 0; i < frac.Length; i++)
            {
                if (i == 0 && frac[i] == '-')
                {
                    i++;
                }

                if ((frac[i] == '/' && i != frac.Length - 1))
                {
                    i++;
                }

                if (frac[i] == '0' && frac.Length == 1)
                {
                    return false;
                }

                if (!char.IsDigit(frac[i]) || (frac[i] == '0' && i == frac.Length - 1 && frac[i - 1] == '/'))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter the first number");
            var firstNumber = GettingRationalNumber();
            Console.Clear();
            Console.Write("Enter the second number");
            var secondNumber = GettingRationalNumber();

            Console.Clear();
            Console.WriteLine("The first number: " + firstNumber);
            Console.WriteLine("The second number: " + secondNumber);

            Console.Write("{0} + {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber + secondNumber);

            Console.Write("{0} - {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber - secondNumber);

            Console.Write("{0} * {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber * secondNumber);

            Console.Write("{0} / {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber / secondNumber);

            Console.Write("{0} > {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber > secondNumber);

            Console.Write("{0} < {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber < secondNumber);

            Console.Write("{0} == {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber == secondNumber);

            Console.Write("{0} != {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber != secondNumber);
        }

    }
}