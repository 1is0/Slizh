using System;
using System.Runtime.InteropServices;

namespace LB4_2_
{

    class Program
    {
        [DllImport("C:\\Projects\\c#\\lab4\\2nd\\Dll\\Debug\\Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sum(int a, int b);

        [DllImport("C:\\Projects\\c#\\lab4\\2nd\\Dll\\Debug\\Dll.dll")]
        public static extern int Diff(int a, int b);

        [DllImport("C:\\Projects\\c#\\lab4\\2nd\\Dll\\Debug\\Dll.dll")]

        public static extern int Division(int a, int b);

        [DllImport("C:\\Projects\\c#\\lab4\\2nd\\Dll\\Debug\\Dll.dll")]

        public static extern int Fact(int a);

        [DllImport("C:\\Projects\\c#\\lab4\\2nd\\Dll\\Debug\\Dll.dll")]

        public static extern int Module(int a);

        static void Main(string[] args)
        {
            int sum = Sum(10, 20);
            int dif = Diff(30, 20);
            int div = Division(14, 2);
            int fact = Fact(7);
            int mod = Module(-6);

            Console.WriteLine($"10 + 20 = {sum.ToString()}");
            Console.WriteLine($"30 - 20 = {dif.ToString()}");
            Console.WriteLine($"14 : 2 = {div.ToString()}");
            Console.WriteLine($"Fact 7 = {fact.ToString()}");
            Console.WriteLine($"Module -6 = {mod.ToString()}");
        }
    }
}
