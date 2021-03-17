using System;

namespace Uppgift_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren att mata in ett decimal tal
            Console.WriteLine("Skriv in ett tal med decimal");
            double tal = ReadDouble();
            Console.WriteLine($"Talet du mata in var {tal}");
        }

            // Metod för att läsa upp det användaren skrev
        static double ReadDouble()
        {
            double tal;
            while (double.TryParse(Console.ReadLine(), out tal) == false)
            {
                // Ifall inmatningen var ej giltig
                Console.WriteLine("Ogiltig inmatning, Försök igen!");
            }
            // Upprepar det användaren skrev (ifall det var ett giltigt tal)
            return tal;
        }
    }
}
