using System;

namespace Uppgift_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
          //Läs in en addition text "4++3"
        Console.WriteLine("ange en addition");
        String addition = Console.ReadLine();
          //Plocka ut talen
        int position = addition.IndexOf("+");
        int tal1 = int.Parse(addition.Substring(0, position));
        int tal2 = int.Parse(addition.Substring(position + 1));

          //Räkna ut summan
        int summa = tal1 + tal2;

          //Skriv ut svaret
        Console.WriteLine(addition + " = " + summa);

        }
    }
}
