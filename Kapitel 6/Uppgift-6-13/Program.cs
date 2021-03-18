using System;

namespace Uppgift_6_13
{
    class Program
    {
        /// <summary>
        /// Slumpar tal
        /// </summary>
        /// <returns>slumptal</returns>
        static Random slump = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine($"År {SlumpÅrtal()}");
            Console.WriteLine($"Månad {SlumpMånad()}");
        }

        /// <summary>
        /// Slumpar ett årtal mellan 1900-1999
        /// </summary>
        /// <returns>slump år</returns>
        static int SlumpÅrtal()
        {
            return slump.Next(1900, 2000);
        }

        /// <summary>
        /// Slumpar en månad
        /// </summary>
        /// <returns>slump månad</returns>
        static int SlumpMånad()
        {
            return slump.Next(1, 13);
        }
    }
}
