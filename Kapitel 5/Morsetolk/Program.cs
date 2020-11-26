using System;

namespace Morsetolk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berätta om programmet
            Console.WriteLine("Det här programmet översätter svensk morsekod. ");

            // Be om ett medalande
            Console.WriteLine("Ange ett meddelande: ");
            string meddelande = Console.ReadLine();

            // Översätt bokstav till morsekod
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

            //skapa en samling för morsek
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
             ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--",
              "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "" };


            // loppa meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                // Skriv ut varje tecken
                string bokstav = meddelande[i].ToString();
                // Console.WriteLine($"{bokstav}");

                //hitta bokstavens plats i alfabetet
                int index = alfabetet.IndexOf(bokstav);

                //skriv ut morsekoden för bokstaven
                string morseBokstav = morse[index];
                // Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");  

                // samla in hela meddelandet i morsekod
                morseMeddelande += morseBokstav ;
            }

            // Skriv ut hela meddelandet i morsekod
            Console.WriteLine(morseMeddelande);

            // vart fanns bokstaven?
            Console.WriteLine($"{bokstav} finns på position {index}");
        }
    }
}
