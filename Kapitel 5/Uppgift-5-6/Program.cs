using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ger info till användaren
            Console.WriteLine("Du får nu skriva in 5 städer");

            // Skriv in en array
            string[] städer = new string[5];

            // Loppar frågan 5 gånger till användaren
            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine($"Skriv in stad {i+1}");
                städer[i] = Console.ReadLine();
            }

            // Skriver ut svaret till användaren
            Console.WriteLine("Här är de 5 städer som du skrev in");

            foreach (string stad in städer)
            {
                Console.WriteLine(stad);
            }

        }
    }
}
