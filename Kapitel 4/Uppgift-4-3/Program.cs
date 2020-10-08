using System;

namespace Uppgift_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett omvandlingsprogram");

            string val = "";

            while (val != "3")
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett av alternativerna");
                Console.WriteLine("1. Omvandla meter till kilometer");
                Console.WriteLine("2. Omvandla kilometer till meter");
                Console.WriteLine("3. Avsluta program");
                val = Console.ReadLine();                

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in längden i meter");
                        double antalMeter = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Längden du skrev in är detsamma som {antalMeter / 1000} km");
                        break;

                    case "2":
                        Console.WriteLine("Skriv in längden i km");
                        double antalKm = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Längden du skrev in är detsamma som {antalKm * 1000} meter");
                        break;

                    case "3":
                        Console.WriteLine("Programmet avslutas");
                        break;

                    default:
                        Console.WriteLine("Jag förstod int vad du menade");
                        break;
                }   }
            }        
    }
}
