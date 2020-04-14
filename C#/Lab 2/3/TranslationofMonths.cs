using System;
using System.Globalization;
using System.Threading;
using System.Text;

namespace TranslationOfMonths
{
    class TranslationOfMonths
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Enter a language: es-spanish,fr-french,ru-russian,en-english");
            string language = Console.ReadLine();
            while (language!="fr"||language!="es"||language!="ru"||language!="en")
            {
                if (language == "fr") break;
                if (language == "es") break;
                if (language == "ru") break;
                if (language == "en") break;
                Console.WriteLine("Error, chose between given languages:");
                language = Console.ReadLine();
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            DateTime now = new DateTime(2020, 1, 1);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(now.ToString("MMMM"));
                now = now.AddMonths(1);
            }
        }
    }
}