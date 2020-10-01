using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett tal
            Random slump = new Random();
            int slumptal = slump.Next(1,7);

            // Fråga fem gånger
 
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Gissa ett tal 1-6");
                int gissning = int.Parse(Console.ReadLine());

                // Kolla om gissningen är rätt
                if (gissning == slumptal)
                {
                Console.WriteLine("Rätt svar!");
                }
                else
                {
                Console.WriteLine("Fel svar!");
                }
            }
        }
    }
}
