using System;

namespace Uppgift_Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "";

            Console.WriteLine("Hej och välkomen till Robins frågesport, var vänlig och ange ditt namn!");
            namn = Console.ReadLine();

            Console.WriteLine("Vi börjar med fråga no.1, Hur gammal var Boxaren Mike Tyson när han först blev en proffs? Var det 1) När han var 17. | 2) När han var 19. | 3) När han var 21. (Svara med nummer)");
            int svar1 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (int.TryParse(input, out svar1))
            {
                if (int.TryParse(input, out svar1))
                {
                Console.WriteLine("Bra att du svarade med ett heltal!");

                        if (svar1 !=2)
                        {
                            Console.WriteLine("Du har tyvärr fel, försök igen!");
                        }
                }

                else
                {
                    Console.WriteLine("Du har rätt, +1p!");
                }
            }
            Console.WriteLine("");
        }

    }
}
