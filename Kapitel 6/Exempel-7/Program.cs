using System;

namespace Exempel_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en text att kryptera:");
            string meddelande = Console.ReadLine();

            Console.WriteLine($"Krypterat med 1 steg:{CeasarKryptera(meddelande)}");
            Console.WriteLine($"Krypterat med 3 steg:{CeasarKryptera(meddelande, 3)}");
        }

        /// <summary>
        /// Krypterar meddelande 
        /// </summary>
        /// <param name="text">meddelandet som du anger</param>
        /// <param name="nyckel">hur många steg chiffret har</param>
        /// <returns>skriver ut den färdiga krypteringen</returns>
        static string CeasarKryptera(string text, int nyckel = 1)
        {
            // Loopa igenom texten, tecken för tecken
            string textKrypterat = "";
            for (int i = 0; i < text.Length; i++)
            {
                // Plocka ut ett tecken
                char tecken = text[i];

                // Ta reda på tecken koden
                int teckenKod = (int)tecken;

                // Räkna ut krypterat tecken
                int teckenKodKrypterat = teckenKod + nyckel;
                
                // Tillbaka till tecken
                char teckenKrypterat = (char)teckenKodKrypterat;

                // Sätta samma krypterat text
                textKrypterat += teckenKrypterat;
            }
            return textKrypterat;   
        }
    }
}
