using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace LB4
{
    class Program
    {


        [DllImport("User32.dll", EntryPoint = "GetAsyncKeyState")]
        public static extern int Key(int x);
        static void Main(string[] args)
        {
            while (true)
            {

                Thread.Sleep(100);
                //Немного побаловался с выводом
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;


                for (int i = 32; i < 127; i++)
                {
                    int keyState = Key(i);
                    if (keyState == 32768)
                    {
                        Console.WriteLine("You pressed - {0}", (char)((char)i));
                    }
                }
            }
        }
    }
}