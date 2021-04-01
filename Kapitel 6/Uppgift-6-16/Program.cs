using System;

namespace Uppgift_6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("Hej");
            Console.WriteLine();
            SkrivVertikalt("Programmering", 2);
        }

        /// <summary>
        /// Skriv ut vertikalt
        /// </summary>
        /// <param name="text">meddelandet som ska skrivas ut vertikalt</param>
        /// <param name="antalTommaRader">tomma rader mellan tecken</param>
        static void SkrivVertikalt(string text, int tomaRader = 0)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
                for (int x = 0; x < tomaRader; x++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
