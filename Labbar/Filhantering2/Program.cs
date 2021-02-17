using System;
using System.IO;

namespace Filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filnamn = "./animals.txt";

            string[] rader = File.ReadAllLines(filnamn);
            
            int counter = 1;
            foreach (var rad in rader)
            {
                Console.WriteLine(counter + " - " + rad );
                counter++;
            }
            Console.WriteLine($"det finns: {counter-1} djur");
        }
    }
}
