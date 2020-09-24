using System;

namespace Uppgift_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in en ålder
            Console.Write("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());

            // Svara om man får extrapriset eller inte
            // äldre än 65 och mellan 10-18 år
            if (ålder > 65 || (ålder > 10 && ålder < 18))
            {
                System.Console.WriteLine("Du får rabbaten");
            }

            else 
            {
                System.Console.WriteLine("Du får inte rabbaten");
            }

        }
    }
}
