using System;

namespace Uppgift_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // matar in ett tal
            Console.WriteLine("Skriv in ett tal");
            string tal = Console.ReadLine();

           // Deklarerar bool 
            bool finns3eller7 = false;

            // plockar ut siffrorna 3 och/eller 7 från talet
            for (int i = 0; i < tal.Length; i++)
            {
                if (tal[i] == '3' || tal[i] == '7')
                {
                    finns3eller7 = true;
                }
            }

            // ifall talet inehåller 3 och/eller 7
            if (finns3eller7)
            {
                Console.WriteLine("Din coola tal innehåller siffran 3 och/eller 7");
            }

            // ifall talet inte inehåller 3 och/eller 7
            else
            {
                Console.WriteLine("skulle vara coolare ifall talet inehöll minst en 3a eller 7a");
            }
        }
    }
}
