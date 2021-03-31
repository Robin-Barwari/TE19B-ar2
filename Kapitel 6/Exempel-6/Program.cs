using System;

namespace Exempel_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Använder den första metoden
            SkrivVertikalt("Hej");

            // Testa den andra metoden
            SkrivVertikalt(12);
        }

        static void SkrivVertikalt(string meddelande)
        {
            // Loopa igenom textan tecken för tecken
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }

        }

        static void SkrivVertikalt(int tal)
        {
            SkrivVertikalt(tal.ToString());
        }
    }
}
