using System;

namespace Hitta_bokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            //ange en bokstav
            Console.WriteLine("ange en bokstav: ");
            string bokstav = Console.ReadLine();

            //för säkerhetsskull omvandla till versaler
            bokstav = bokstav.ToUpper();

            //skapa en samling för alfabetet (string)
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

            //hitta bokstavens plats i alfabetet
            int index = alfabetet.IndexOf(bokstav);

            // vart fanns bokstaven?
            Console.WriteLine($"{bokstav} finns på position {index}");

            //skapa en samling för morsek
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "" };

            Console.WriteLine($"{morse[0]} {morse[20]}");

            //skriv ut morsekoden för bokstaven
            string morseBokstav = morse[index];
            Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");   
        }
    }
}
