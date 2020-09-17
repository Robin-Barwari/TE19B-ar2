using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
           //läs in texten
           Console.Write("Ange två ord med mellanslag emellan");
           String texten = Console.ReadLine();

           //dela upp texten
           int position = texten.IndexOf(" ");
           string Ordföre = texten.Substring(0, mellanslag);
           string Ordefter = texten.Substring(mellanslag + 1);

           //Skriv ut i omvänd ordning
           Console.WriteLine(Ordefter + " " + ordföre);
        }
    }
}
