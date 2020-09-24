using System;

namespace Uppgift_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läsa i längd
            Console.Write("Hur lång är du? ");
            double längd = double.Parse(Console.ReadLine());

            // Svara med om man får eller inte åka
            if (1.5 < längd && längd <1.9)
            {
                Console.WriteLine("du får åka berg-o-dal-bana");
            }

            else
            {
                System.Console.WriteLine("Du får inte åka");
            }

        }
    }
}
