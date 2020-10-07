using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // Deklarera variabler
            string val = "";

        // Presentera en ny meny som visas tills användaren säger stopp
        while (val != "3")
        {
            Console.WriteLine("Välj något av följande val:");
            Console.WriteLine("1. addera två tal ");
            Console.WriteLine("2. multiplicera två tal ");
            Console.WriteLine("3. avsluta ");

            // Läs in användarens val
            val = Console.ReadLine();

            // Om val = 1
            if (val == "1")
            {
                Console.WriteLine("Skriv in två tal på var sin rad");
                double tal1 = double.Parse(Console.ReadLine());
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
            }

            // Om val = 2
            else if (val == "2")
            {
                Console.WriteLine("Skriv in två tal på var sin rad");
                double faktor1 = double.Parse(Console.ReadLine());
                double faktor2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{faktor1} * {faktor2} = {faktor1 * faktor2}");
            }

            // Om val = 3
            else if (val == "3")
            {
                Console.WriteLine("Stick härifrån.");
                break;
            }

            // Annars
                else
            {
                 Console.WriteLine("Du valde inte ett giltigt alternativ.");
            }

            switch (val)
            {
                case "1":
                Console.WriteLine("Skriv in två tal på var sin rad");
                double tal1 = double.Parse(Console.ReadLine());
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
                break;

                case "2":
                Console.WriteLine("Skriv in två tal på var sin rad");
                double faktor1 = double.Parse(Console.ReadLine());
                double faktor2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{faktor1} * {faktor2} = {faktor1 * faktor2}");
                break;     

                case "3":
                Console.WriteLine("Stick härifrån.");
                break;

                default:
                Console.WriteLine("Var vänlig och välj mellan 1, 2, 3");
                break;

            }
        }
        }
    }
}
