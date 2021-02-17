using System;

namespace Omprov_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            string igen = "j";
            while (igen == "j")
            {
            // Förklarar vad programmet gör
            Console.WriteLine("Hej och välkommen till BMI beräknaren.");
            Console.WriteLine("Börja med att mata in din längd i cm och sedan din vikt i kg.");

            Console.WriteLine("Längd:"); // Mata in längd
            int längdcm= int.Parse(Console.ReadLine());
            double längd = längdcm / 100 ;

            Console.WriteLine("Vikt:"); // Mata in vikt
            int vikt = int.Parse(Console.ReadLine()); 
            double BMI = vikt / längd * längd; // BMI beräkningen

            if (BMI < 16.00) 
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du är kraftigt underviktig");
            }
            
            else if (BMI >= 16.99 && BMI < 16.00)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du är underviktig");
            }

            else if (BMI >= 18.49 && BMI < 17.00)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du kan vara lite underviktig");
            }

            else if (BMI >= 24.99 && BMI < 18.50)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du har en normal BMI");
            }

            else if (BMI >= 27.49 && BMI < 25.00)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du kan vara lite överviktig");
            }

            else if (BMI >= 29.99 && BMI < 27.50)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du är överviktig");
            }

            else if (BMI >= 34.99 && BMI < 30.00)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du är överviktig, fetma klass 1");
            }

            else if (BMI >= 39.99 && BMI < 35.00)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du är överviktig, fetma klass 2");
            }

            else if (BMI > 40.00)
            {
                Console.WriteLine("Din BMI är " + BMI + ". " + "Du har sjuklig fetma");
            }
            
            // Anslutningsvis frågar programmet om användaren vill göra en ny beräkning
                Console.Write("Vill du räkna om din BMI. (j/n)");
                igen = Console.ReadLine();
                igen = igen.ToLower();
            }
        }
    }
}

