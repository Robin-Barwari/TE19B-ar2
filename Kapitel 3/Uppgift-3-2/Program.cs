using System;

namespace Uppgift_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in text USA
            Console.WriteLine("Vilket land vann fotbolls VM för Damer 2015?");
            string vinnare = Console.ReadLine();

            //Sanera inmatningen
            vinnare = vinnare.ToLower();

            //Kontrollera om rätt svar
            if (vinnare == "usa")
            {
                Console.WriteLine("Rätt svar");
            }
            else
            {
                Console.WriteLine("Fel svar");
            }
        }
    }
}
