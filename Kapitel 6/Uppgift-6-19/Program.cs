using System;

namespace Uppgift_6_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Störst(34, 43));
        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            return tal2;
        }
    }
}
