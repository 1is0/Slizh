using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    class Program
    {
       

        static void Main()
        {
            Console.Write("Enter first side of triangle:");
            float side1 = Funcs.CheckFloat();
            Console.Write("Enter second side of triangle");
            float side2 = Funcs.CheckFloat();
            Console.Write("Enter third side of triangle:");
            float side3 = Funcs.CheckFloat();
            if (Funcs.IsExist(side1, side2, side3))
            {
                Console.WriteLine("Perimeter: " + (side1 + side2 + side3));
                Console.WriteLine("Area: " + Funcs.Square(side1, side2, side3));
                Console.WriteLine("Radius of circumscribed circle: " + Funcs.RadiusOfCircumscribedCircle(side1, side2, side3));
                Console.WriteLine("Radius of inscribed circle: " + Funcs.RadiusOfInscribedCircle(side1, side2, side3));
                Funcs.CalculatingOfCorners(side1, side2, side3);
            }
            else
            {
                Console.WriteLine("This triangle isnt exist.");
            }
        }
    }
}