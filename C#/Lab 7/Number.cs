using System;

namespace Lab7
{
    class Number : IEquatable<Number>, IComparable
    {
        double value;

        public int Numerator { get; set; }

        public int Denominator { get; set; }

        public Number()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Number(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            value = (double)numerator / denominator;
        }

        public Number(double x)
        {
            value = x;

            if (x % 10 == 0)
            {
                Numerator = (int)x;
                Denominator = 1;
            }

            else
            {
                int i = 0;
                while (x % 10 != 0)
                {
                    x *= 10;
                    i++;
                }

                i--;
                x /= 10;

                Numerator = (int)x;
                Denominator = (int)Math.Pow(10, i);

                Decrease();
            }
        }

        public static Number operator +(Number firstNumber, Number secondNumber)
        {
            Number num = new Number();

            num.Numerator = firstNumber.Numerator * secondNumber.Denominator + firstNumber.Denominator * secondNumber.Numerator;
            num.Denominator = firstNumber.Denominator * secondNumber.Denominator;
            num.value = firstNumber.value + secondNumber.value;

            num.Decrease();

            return num;
        }

        public static Number operator -(Number n1, Number n2)
        {
            Number num = new Number();

            num.Numerator = n1.Numerator * n2.Denominator - n1.Denominator * n2.Numerator;
            num.Denominator = n1.Denominator * n2.Denominator;
            num.value = n1.value - n2.value;

            num.Decrease();

            return num;
        }
        public static Number operator *(Number n1, Number n2)
        {
            Number num = new Number();

            num.Numerator = n1.Numerator * n2.Numerator;
            num.Denominator = n1.Denominator * n2.Denominator;
            num.value = n1.value * n2.value;

            num.Decrease();

            return num;
        }
        public static Number operator /(Number n1, Number n2)
        {
            Number num = new Number();

            num.Numerator = n1.Numerator * n2.Denominator;
            num.Denominator = n1.Denominator * n2.Numerator;
            num.value = n1.value / n2.value;
            if (n1 < 0 || n2 < 0)
            {
                num.Numerator = -num.Numerator;
                num.Denominator = Math.Abs(num.Denominator);
            }

            num.Decrease();

            return num;
        }
        public bool Equals(Number other) => value == other.value;

        public int CompareTo(object obj)
        {
            if (this.value > ((Number)obj).value)
            {
                return 1;
            }

            if (this.value < ((Number)obj).value)
            {
                return -1;
            }

            else
            {
                return 0;
            }
        }

        public static bool operator <(Number firstNumber, Number secondNumber) => firstNumber.value < secondNumber.value;

        public static bool operator >(Number firstNumber, Number secondNumber) => firstNumber.value > secondNumber.value;

        public static bool operator <=(Number firstNumber, Number secondNumber) => firstNumber.value <= secondNumber.value;

        public static bool operator >=(Number firstNumber, Number secondNumber) => firstNumber.value >= secondNumber.value;

        public static bool operator ==(Number firstNumber, Number secondNumber) => firstNumber.Equals(secondNumber);

        public static bool operator !=(Number firstNumber, Number secondNumber) => !firstNumber.Equals(secondNumber);

        public static explicit operator int(Number number) => (int)number;

        public static implicit operator double(Number number) => number.value;


        public override string ToString()
        {
            if ((value - (int)value) != 0)
            {
                return $"{Numerator}/{Denominator}";
            }
            else
            {
                return $"{value}";
            }
        }

        void Decrease()
        {
            int GCT(int x, int y)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);
                while (x != 0 && y != 0)
                {
                    if (x >= y)
                        x %= y;

                    else
                        y %= x;
                }

                return x | y;
            }

            while (GCT(Numerator, Denominator) != 1)
            {
                int n = GCT(Numerator, Denominator);
                Numerator /= n;
                Denominator /= n;
            }
        }
    }
}