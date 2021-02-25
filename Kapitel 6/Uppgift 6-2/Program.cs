using System;

namespace Uppgift_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Undrat hur din text skulle se ut baklänges?");
            Console.WriteLine("Ange din text så får vi se.");
            SkrivBaklänges(Console.ReadLine());
        }
        static void SkrivBaklänges (string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
            Console.WriteLine();
        }
    }
}
