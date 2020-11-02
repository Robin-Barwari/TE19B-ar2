using System;

namespace Öningsprov
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Räkna ut vad X är i följande fråga!");
            // Console.WriteLine("X * 6 = 42");
            // int svar = Console.ReadLine();
            // if (svar != 7)
            // {
            //     Console.WriteLine("Din intellekt skrämmer mig!");
            // }
            int poäng = 0;
            int gissning = 0;
            string gissningstext = "";

            Console.WriteLine("Vad är x i formeln x * 6 = 42?");

            while (lyckades == false)
            {
                gissningstext = Console.ReadLine();

                lyckades = int.TryParse(gissningstext, out gissning);

                Console.WriteLine("Fel! mata in ett TAL!");
            }

            if (gissning == 7)
            {
                Console.WriteLine("Du har rätt");
            }

            else
            {
                Console.WriteLine("Din intellekt skrämmer mig!");
            }
        }
    }
}
