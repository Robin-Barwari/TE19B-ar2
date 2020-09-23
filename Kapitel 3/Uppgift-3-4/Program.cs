using System;

namespace Uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in poäng
            Console.WriteLine("Hur många poäng fick du?");
            string poäng = Console.ReadLine();

            // Skriv ut poäng
            if (poäng == "55")
            {
            Console.WriteLine("Du har betyget A!");
            }
            
            else if (poäng >=46)
            {
                Console.WriteLine("Du har betyget B");
            }

             else if (poäng >=35)
             {
                 Console.WriteLine("Du har betyget C");
             }

             else if (poäng >=27)
             {
                 Console.WriteLine("Du har betyget D");
             }

             else if (poäng >=18)
             {
                 Console.WriteLine("Du har betyget E");
             }

             else
             {
                 Console.WriteLine("F");
             }
    }
}

