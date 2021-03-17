using System;

namespace Uppgift_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivTalIKvadrat(5);

            SkrivTalIKvadrat(40);

            SkrivTalIKvadrat(25);

        }
        /// <summary>
        /// Metoden skriver ut svaret
        /// </summary>
        /// <param name="tal">Siffrorna inom paranteserna</param>
        static void SkrivTalIKvadrat(int tal) {
            Console.WriteLine($"Talet {tal} upphöjt med två är {tal * tal}");
        }
    }
}
