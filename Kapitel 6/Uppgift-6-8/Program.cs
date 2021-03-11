using System;

namespace Uppgift_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"I denna text så upprepas bokstaven p {AntalISträng('p', "I denna text så upprepas bokstaven")} gånger.");
        }

        static int AntalISträng(char tecken, string text)
        {
            int antalP = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == tecken)
                {
                    antalP++;
                }
            }
            return antalP;

        }
    }
}
