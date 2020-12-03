using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dikt = {
                "Den mätta dagen, den är aldrig störst.",      //0
                "Den bästa dagen är den av törst.",            //1

                "Nog finns det mål och mening i vår färd.",    //2
                "men det är vägen, som är mödan värd.",        //3

                "Det bästa målet är en nattlång rast,",        //4
                "där elden tänds och brödet bryts i hast.",    //5

                "På ställen, där man sover blott en gång,",    //6
                "blir sömnen trygg och drömmen full av sång.", //7

                "Bryt upp, bryt upp! Den nya dagen gryr.",     //8
                "Oändligt är vårt stora äventyr."              //9
            };
            // // Skriv ut dikten
            // // Loopa igenom arrayen
            // foreach (var rad in dikt)
            // {
            //     Console.WriteLine(rad);
            // }

            //skriv som verser
            // Looper igenom arrayen
            for (int i = 0; i < dikt.Length; i++)
            {
                if (i % 2 != 0)
                {
                    // skriv ut raden
                    Console.WriteLine(dikt[i]);
                }
                else
                {
                    // skriv ut raden + en tim rad
                    Console.WriteLine(dikt[i] + "\n");
                }

                // Dela upp raden i en array av ord
                string[] orden = dikt[i].Split(' ');

                //räkna orden
                int antalOrd = orden.Length;

                // Addera till total antal ord
                totalAntalOrd += antalOrd;
            }

            //Antal ord i dikten
            Console.WriteLine($"Antal ord i dikten är {totalAntalOrd += antalOrd}" );

        }
    }
}
