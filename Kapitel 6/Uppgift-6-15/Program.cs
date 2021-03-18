using System;

namespace Uppgift_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en utav dessa alternativ för att se de baklänge");
            Console.WriteLine("Mike Tyson");
            Console.WriteLine(1980);
            Console.WriteLine("17,89");
        }

        static void SkrivBaklänges(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }

        static void SkrivBaklänges(int heltal)
        {

        }
    }
}
