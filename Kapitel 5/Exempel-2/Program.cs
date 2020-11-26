using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // be om text
            Console.WriteLine("Ange en text: ");
            string text = Console.ReadLine();

            // dela texten i separat ord
            string[] orden = text.Split(' ');

            // loppa igenom arrayen
            // for (int i = 0; i < length; i++)
            // {
            //     Console.WriteLine($"ord {i + 1}: {orden[i]}");
            // }

            // Alternativ 2 - foreach
            int i = 0;
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
                i++;
            }

            // skriv ut antalet ord
            Console.WriteLine($"Antal ord {orden.Length}");
        }
    }
}
