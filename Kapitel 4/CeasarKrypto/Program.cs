using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange en text
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            // Loopa igenom inmattad text bokstav för bokstav
            int textlängd = text.Length;
            Console.WriteLine($"Texten är {textlängd} tecken lång");

            // Användaren skriver in ett tal
            Console.WriteLine("Ange en nyckel (1-9): ");
            string nyckelstring = Console.ReadLine();

            //säkerställa att vi får in ett tal
            int nyckel = 0;
            while (!int.TryParse(nyckelString, out nyckel))
            {
                Console.Write("Du måste mata in ett tal! Ange en nyckel (1-9)");
            }

            // säkerställa att vi får in ett tal
            string krypteradtext = "";
            for (int i = 0; i < textlängd; i++)
            {
                Console.WriteLine($"Loop nr {i}");

                // Plocka ut bokstav på position i
                char bokstav =text[i];
                Console.WriteLine($"Bokstaven på positionen {i} är {bokstav}");

                // ASCII-värdet för ett tecken
                int ascii = (int)bokstav;
                Console.WriteLine($"Bokstaven {bokstav} har ASCII-värdet {ascii}");

                // Ceasar kryptering
                ascii = nyckel;

                // Plocka ut motsvarande tecken enligt ASCII-tabellen
                char krypteradbokstav = (char)ascii;
                Console.WriteLine($"Bokstaven {bokstav} krypteras till {krypteradbokstav}");

                //samla ihop bokstäverna
                krypteradtext += krypteradbokstav.ToString();
            }
            // slriv ut de krypterade texten
            Console.WriteLine($"Det krypterade meddelandet är {krypteradtext}");
        }
    }
}
