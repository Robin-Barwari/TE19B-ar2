using System;

namespace Uppgift_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("Mike Tyson");
            SkrivBaklänges(1980);
            SkrivBaklänges(17.89);
        }

        /// <summary>
        /// Skriver baklänges
        /// </summary>
        /// <param name="text">meddelandet i static void main</param>
        static void SkrivBaklänges(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Skriver heltal baklänges
        /// </summary>
        /// <param name="heltal">står för tal utan decimal</param>
        static void SkrivBaklänges(int heltal)
        {
            SkrivBaklänges(heltal.ToString());
        }

        /// <summary>
        /// Skriver decimaltal baklänges
        /// </summary>
        /// <param name="tal">står för decimal</param>
        static void SkrivBaklänges(double tal)
        {
            SkrivBaklänges(tal.ToString());
        }
    }
}
