using System;

namespace Uppgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in ett årtal
            Console.WriteLine("Ange ett årtal");
            int årtal = int.Parse(Console.ReadLine());

            // Räkna ut antal år till 2100
            int antalÅr = 2100 - årtal;

            //skriv ut resultatet
            Console.WriteLine("Antal år kvar till 2100 är " + antalÅr); 
        }
    }
}
