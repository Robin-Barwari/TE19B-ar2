using System;

namespace Uppgift_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string land = "";

            while (land != "kina")
            {
                Console.WriteLine("vilket land är den folkrikaste landet ?");

                land = Console.ReadLine();

                if (land =="kina")
                {
                    Console.WriteLine("Du har rätt");
                }
                else
                {
                    Console.WriteLine("Du har fel försök igen!");
                }
            }
        }
    }
}
