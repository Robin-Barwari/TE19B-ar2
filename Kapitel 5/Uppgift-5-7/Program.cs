using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talLista = { 95, 11223, 123, -150, -1200 };

            int summa = 0;

            foreach (int tal in talLista)
            {
                summa += tal;
            }

            Console.WriteLine($"Summan av talen är {summa}");
        }
    }
}
