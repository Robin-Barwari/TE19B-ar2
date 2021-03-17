using System;

namespace Uppgift_6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren att mata in något
            Console.WriteLine("skriv in vad du än vill");
            Heltal();
        }

        static void Heltal()
        {
            int svar = 0;
            if(!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("Du angav ej ett heltal");
            }
            else
            {
                Console.WriteLine("Du matade in ett heltal");
            }
        }
    }
}
