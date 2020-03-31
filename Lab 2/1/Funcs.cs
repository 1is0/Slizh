using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    class Funcs
    {
        public static float CheckFloat()
        {
            float a;
            while (!float.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Enter float parameter. ");
            }
            return a;
        }

        public static bool IsExist(float side1, float side2, float side3)
        {
            if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2) return true;
            else return false;
        }

        public static float Perimetr(float side1, float side2, float side3)
        {
            return side1 + side2 + side3;
        }

        public static float Square(float side1, float side2, float side3)
        {
            float Halfperimetr = Perimetr(side1, side2, side3) / 2;
            return (float)Math.Sqrt(Halfperimetr * (Halfperimetr - side1) * (Halfperimetr - side2) * (Halfperimetr - side3));
        }

        public static float RadiusOfCircumscribedCircle(float side1, float side2, float side3)
        {
            return (side1 * side2 * side3) / (4 * Square(side1, side2, side3));
        }

        public static float RadiusOfInscribedCircle(float side1, float side2, float side3)
        {
            return (Square(side1, side2, side3) / (Perimetr(side1, side2, side3) / 2));
        }

         public static void CalculatingOfCorners(float side1, float side2, float side3)
        {
            float x = (side2 * side2 + side3 * side3 - side1 * side1) / (2 * side2 * side3);
            float y = (side1 * side1 + side3 * side3 - side2 * side2) / (2 * side1 * side3);
            float z = (side1 * side1 + side2 * side2 - side3 * side3) / (2 * side1 * side2);
            Console.WriteLine("First corner =" + (Math.Acos(x) * 180 / Math.PI));
            Console.WriteLine("Second corner =" + (Math.Acos(y) * 180 / Math.PI));
            Console.WriteLine("Third corner =" + (Math.Acos(z) * 180 / Math.PI));
        }
    }
}
