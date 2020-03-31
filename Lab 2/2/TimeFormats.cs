using System;

    class TimeFormats
    {
        static void Main()
        {
            System.DateTime time = DateTime.Now;
            string firstFormat = time.ToString("R");
            string secondFormat = time.ToString("G");
            Console.WriteLine(firstFormat);
            Console.WriteLine(secondFormat);
            Functions.Calculating(firstFormat);
            Console.WriteLine("------------------------------------");
            Functions.Calculating(secondFormat);
        }
    }
    

