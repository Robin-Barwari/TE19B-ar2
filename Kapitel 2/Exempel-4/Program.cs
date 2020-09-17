using System;

namespace Exempel_4
{
    class Program
    {
        // En fallgrop när man räknar med heltal
        // static void Main(string[] args)
        {
             double delat = 7/2;
            Console.WriteLine("delat = " + delat1);

            double delat = (double)7/2;
            Console.WriteLine("delat = " + delat2);

            double delat = 7d/2;
            Console.WriteLine("delat = " + delat3);

            float delat = 7f/2;
            Console.WriteLine("delat = " + delat4);
            
            // Läs in epost-adress
            Console.Write("Ange ett email: ");
            string email = Console.ReadLine();

            //Leta efter ett tecken i en text
            int position = email.IndexOf("@");
            Console.WriteLine("@ ligger på position = " + position);

            //plocka namnet
            string namn = EnvironmentVariableTarget.Substring(0, postition);
            Console.WriteLine("namndelen = " + namn");

            //Plocka ut domänet
            string domän = EnvironmentVariableTarget.Substring(position +)

           // --> slutet
           Console.Writeline("Domändelen = " + domän);
        }
    }
}
