using System;

namespace Uppgift_6_14
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
            SlumpPosition();
        }

        /// <summary>
        /// Slumpar ett tal
        /// </summary>
        /// <returns>slumptal</returns>
        static int SlumpSiffra()
        {
            return slump.Next(1, 9);
        }

        /// <summary>
        /// Slumpar en bokstav
        /// </summary>
        /// <returns>random bokstav</returns>
        static char SlumpBokstav()
        {
            string bokstav = "ABCDEFGH";
            int slumpBokstav = slump.Next(0, bokstav.Length);
            return bokstav[slumpBokstav];
        } 

        /// <summary>
        /// Skriver ut en random position på brädan
        /// </summary>
        static void SlumpPosition()
        {
            Console.WriteLine($"{SlumpBokstav()}{SlumpSiffra()}");
        }
    }
}
