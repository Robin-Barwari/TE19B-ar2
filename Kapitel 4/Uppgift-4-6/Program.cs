using System;

namespace Uppgift_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // meddelande
            string meddelande = "Potatis";

            // skriver ut meddelandet baklänges och vertikalt
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
