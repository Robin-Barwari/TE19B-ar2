using System;

namespace Uppgift_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matar in ett tal
            Console.WriteLine("Mata in ett tal");
            string text = Console.ReadLine();

            // Beräknar summan av talet
            int summa = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string teckenString = text[i].ToString();
                int tal = int.Parse(teckenString);
                summa += tal;
            }

            // Skriver ut vad summan av talet är
            Console.WriteLine($"Summan av talet {text} är {summa}");
        }
    }
}
