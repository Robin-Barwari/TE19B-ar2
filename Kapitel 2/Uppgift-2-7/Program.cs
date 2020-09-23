using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
           //läs in texten
           Console.Write("ange en mening med 2 ord: ");
           String mening = Console.ReadLine();

           //dela upp texten
           int mellanslag = mening.IndexOf(" ");
           string Ordföre = mening.Substring(0, mellanslag);
           string Ordefter = mening.Substring(mellanslag + 1);

           //Skriv ut i omvänd ordning
           Console.WriteLine(Ordefter + " " + Ordföre);
        }
    }
}
