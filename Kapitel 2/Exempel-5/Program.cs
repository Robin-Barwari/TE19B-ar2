using System;

namespace Exempel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Robin";
            Console.WriteLine("Mitt namn är " + namn);
            //Mha vriabelsubtitution
            Console.WriteLine($"Mitt namn är {namn}.");

            String svar = $"Mitt förnamn är {namn}.";
            Console.WriteLine(svar);
            System.Console.WriteLine();
            Cosole.Readline();
                }
    }
}
