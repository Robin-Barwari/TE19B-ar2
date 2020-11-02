using System;

namespace Uppgift_3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ålder för att delta i tävlingen!");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >=  16 && ålder <= 19) 
            {
                Console.WriteLine("Välkomen, och lycka till!");
            }

            else if (ålder > 19) 
            {
                Console.WriteLine("Du är för gammal för att kunna delta i den här tävlingen din BOOMER");
            }

            else
            {
                Console.WriteLine("Gå tillbaka till Roblox din P12");
            }

        }
    }
}
