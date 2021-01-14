using System;
using System.IO;

namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriva till en textfil
            File.WriteAllText("fil1.text" , "Nu snöar det igen! Kul!");

            // Läsa innehållet av en text
            string allText = File.ReadAllText("./Filhantering.csproj");

            // Skriv ut innehållet
            Console.WriteLine($"Innehållet: \n{allText}");

            // Fråga användaren om en filnamn
            Console.Write("Ange filnamn: ");
            string filnamn = Console.ReadLine();

            // Kontrollera att filen finns!
            if (File.Exists(filnamn))
            {
                string texten = File.ReadAllText(filnamn);
                Console.WriteLine(texten);
            }
            else
            {
                Console.WriteLine($"Hittade inte filen \"{filnamn}\"");
            }
        }
    }
}
