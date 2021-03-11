using System;

namespace Uppgift_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett utav följande alternativ.");

            // användarens alternativ
            string alternativ = "";

            // Skriv ut alternativet
            Console.WriteLine();
            while (alternativ != "4")
            {
                Meny();
                alternativ = Console.ReadLine();
                switch (alternativ)
                {
                    case "1":
                    Addera();
                    break;

                    case "2":
                    Subtrahera();
                    break;

                    case "3":
                    Multiplicera();
                    break;

                    case "4":
                    // Avsluta
                    break;

                    default:
                    // Ifall de nämner ett ogiltigt nummer eller bokstav
                    Console.WriteLine("Välj ett giltigt nummer!");
                    break;
                }
            }
        }

        static void Meny()
        {
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Subbtrahera två tal");
            Console.WriteLine("3. Multiplicera två tal");
            Console.WriteLine("4. Avsluta");
        }

        static void Addera()
        {
            Console.WriteLine("Skriv  två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            // Skriv ut svar
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }

        static void Subtrahera()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            // Skriv ut svar
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");            
        }

        static void Multiplicera()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            // Skriv ut svar
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }
    }
}
