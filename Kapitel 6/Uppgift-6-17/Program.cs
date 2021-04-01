using System;

namespace Uppgift_6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("Hej");
            Console.WriteLine();
            SkrivVertikalt("Shalom", 2);
            Console.WriteLine();
            SkrivVertikalt("Pumpa", 2, 4);
            Console.WriteLine();
        }

        static void SkrivVertikalt(string text, int tomaRader = 0, int stegÅtHöger = 0)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
                for (int x = 0; x < tomaRader; x++)
                {
                    Console.WriteLine();
                }
                for (int y = 0; y < stegÅtHöger; y++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
