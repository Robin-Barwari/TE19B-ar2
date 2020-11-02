using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett tal (1-6)
            Random Tärning = new Random();
            int slumptal = Tärning.Next(1, 7);

            //Deklarera variabeln gissning
            int gissning = 0;

            // Loopar tills vi får rätt svar
            while (gissning != slumptal)
            {
                // Fråga in användarens gissning
                Console.WriteLine("Gissa ett tal mellan 1-6");

                // Läs in användarens gissning
                // gissning = int.Parse(Console.ReadLine());

                // En säkrare inmattning
                string input = Console.ReadLine();

                // Försök översätt till ett heltal
                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("Vad bra att du matade in ett tal!");

                    // Kolla om gissningen är fel
                    if (gissning != slumptal)
                    {
                        Console.WriteLine("Tyvärr är det fel svar! Försök igen!");
                    }
                }
                else
                {
                    Console.WriteLine("Nej din dräng, jag fråga efter ett tal! Försök igen!");
                }

            }

            // Rätt svar!
            Console.WriteLine("Rätt Svar!");
        }
    }
}
