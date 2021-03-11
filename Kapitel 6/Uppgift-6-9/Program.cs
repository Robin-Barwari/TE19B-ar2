using System;

namespace Uppgift_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal med decimal");
            double tal = ReadDouble();
            Console.WriteLine($"Talet du mata in var {tal}");
        }

        static void ReadDouble()
        {
            double tal;
            while (double.Parse(Console.ReadLine(), out tal) == false)
            {
                Console.WriteLine("Ogiltig inmatning, Försök igen!");
            }
            return tal;
        }
    }
}
