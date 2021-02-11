using System;
using System.IO;

namespace Projektuppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler och initialisera
            int antalBord = 8;
            string filnamn = "centralbord.csv";
            string tomtBordBeskrivning = "0,Inga gäster";
            string[] bordsInformation; // Arrey för att lagra bokningar

            // Presentera programmet för användaren
            Console.WriteLine("Detta är Centralresturangens bordhanterare");

            // Finns lagringsfilen?
            if (File.Exists(filnamn))
            {
                // Läs in alla rader, dvs bordsbokningar
                bordsInformation = File.ReadAllLines(filnamn);
                Console.WriteLine("Bordsbokningar lästes in från fil");
            }
            else
            {
                // Skapa en tom bordslista i arrayen
                // Lagra detta i filen
                bordsInformation = new string[antalBord]; // 8 nya tomma positioner

                // Fyll arrayen med tomma bord : 0, 1, 2, 3, 4, 5, 6, 7
                for (int i = 0; i < antalBord; i++)
                {
                    bordsInformation[i] = tomtBordBeskrivning;
                }

                // Lagra i filen
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Fil med bordsinformation saknas, ny fil skapades");
            }

            // Huvudloopen
            string menyVal = "";
            while (menyVal != "4")
            {
            // Skriv ut huvudmenyn
            Console.WriteLine("Välja ett alternativ");
            Console.WriteLine("1. Visa alla bord");
            Console.WriteLine("2. Lägg till/ändra bordsinformation");
            Console.WriteLine("3. Markera bord tomt");
            Console.WriteLine("4. Avsluta");
            menyVal = Console.ReadLine();

            // Hantera menyVal
            string antalGäster = "";
            string bordNamn = "";
            int svar = 0, bordNr = 0;
            switch (menyVal)
            {
                case "1":
                int totaltAntalGäster = 0;
                for (int i = 0; i < antalBord; i++)
                {
                    if (bordsInformation[i] == tomtBordBeskrivning) 
                    {
                        // Bordet är tomt
                        Console.WriteLine($"Bord {i + 1} - inga gäster");
                    }
                    else
                    {
                        // Bordet har en bokning
                        // Plocka namn och antal gäster
                        string[] delar = bordsInformation[i].Split(',');
                        antalGäster = delar[0];
                        bordNamn = delar[1];
                        
                        // summera alla gäster
                        totaltAntalGäster += int.Parse(antalGäster);

                        // Skriv ut bokningsinfo
                        Console.WriteLine($"Bord {i + 1} - Namn: {bordNamn}, antal gäster: {antalGäster}");
                    }
                }

                // summera
                Console.WriteLine($"Total antal gäster: {totaltAntalGäster}");
                break;

                case "2":
                // Fråga bordsnr
                Console.WriteLine("Vilket bord vill du ändra på?");
                while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8)
                {
                    Console.WriteLine("Icke giltigt bordsnummer, försök igen");
                }
                bordNr = svar;

                // Fråga namn
                Console.WriteLine("Ange ett namn");
                bordNamn = Console.ReadLine();


                //Fråga antalgäster
                Console.WriteLine("Ange antal gäster?");
                antalGäster = Console.ReadLine();
                // @todo Vad händer om man matar in fel antal gäster


                // spara i arrayen
                bordsInformation[bordNr - 1] = $"{antalGäster},{bordNamn}";


                // Lagra i filen
                File.WriteAllLines(filnamn, bordsInformation);

                break;

                case "3":
                
                // Fråga bordsnr
                Console.WriteLine("Vilket bord vill du tömma?");
                
                // Kontrollera att man matar bord 1-8
                while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8)
                {
                    Console.WriteLine("Icke giltigt bordsnummer, försök igen");
                }
                bordNr = svar;

                // Återställ bordets info till tomt
                bordsInformation[bordNr -1] = tomtBordBeskrivning;

                // Uppdatera sparfilen
                File.WriteAllLines(filnamn, bordsInformation);
                break;

                case "4":
                break;

                default:
                Console.WriteLine("Du valde inte ett giltigt alternativ");
                break;
            }
            }
        }
    }
}
