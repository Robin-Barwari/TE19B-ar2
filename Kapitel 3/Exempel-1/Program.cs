using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in ålder
            Console.WriteLine("Hur gammal är du? (svara i hela antal år) ");
            int ålder = int.Parse(Console.ReadLine());

            // Om ålder = 18 skriv myndig 
            if (ålder >= 18)
            {
                System.Console.WriteLine("Du är myndig. Du får ta körkort");
            }

            //Om ålder är 15 eller högre
            if (ålder >=15)
            {
                System.Console.WriteLine("Du får köra moped");
            }

            //om åldern lägre än 15, skriv du är för ung för ...
            if (ålder < 15)
            {
                System.Console.WriteLine("Du är för ung");
            }

            //Läs in en text
            System.Console.WriteLine("Vem var det som var statsminister i sverige 1970?");
            string statsminister = Console.ReadLine();
            // if (statsminister == "Palme" || statsminister == "palme")
            // {
            //     Console.WriteLine("Rätt svar!");
            // }
            // Sanera inmatningen
            statsminister = statsminister.ToLower();
            if (statsminister == "palme")
            {
                Console.WriteLine("Rätt svar");
            }
            else
            {
                Console.WriteLine("Fel svar");
            }

        }
    }
}
