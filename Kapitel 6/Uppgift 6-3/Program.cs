using System;

namespace Uppgift_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi ska räkna vad alla tal mellan två nummer är i kvadrat");
            // inte färdig
        }
        static void SkrivTalIKvadratMellan(int nedreGräns, int övreGräns)
        {
            for (int i = nedreGräns; i <= övreGräns; i++)
            {
                Console.WriteLine($"talet {i} uphöjt med två är {i * i}");
            }
        }
    }
}
