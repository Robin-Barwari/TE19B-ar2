using System;

namespace Exempel_4
{
    class Program
    {
        // En fallgrop när man räknar med heltal
        static void Main(string[] args)
        {
             double delat1 = 7/2;
            Console.WriteLine("delat = " + delat1);

            double delat2 = (double)7/2;
            Console.WriteLine("delat = " + delat2);

            double delat3 = 7d/2;
            Console.WriteLine("delat = " + delat3);

            float delat4 = 7f/2;
            Console.WriteLine("delat = " + delat4);
            
            // Läs in epost-adress
            Console.Write("Ange ett email: ");
            string email = Console.ReadLine();

            //Leta efter ett tecken i en text
            int position = email.IndexOf("@");
            Console.WriteLine("@ ligger på position = " + position);

            //plocka namnet
            string namn = email.Substring(0, position);
            Console.WriteLine("namndelen = " + namn);

            //Plocka ut domänet
            string domän = email.Substring(position + 1);
            Console.WriteLine("domändelen = " + domän);

        }
    }
}
