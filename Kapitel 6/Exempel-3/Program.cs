using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = Summera(99, 123);

            string omvändText = VändText("Programmering");
        }

        /// <summary>
        /// Etoden summera två tal
        /// </summary>
        /// <param name="x">Försat heltal</param>
        /// <param name="y">Andra heltal</param>
        /// <returns>Summan</returns>
        static int Summera(int x, int y)
        {
            int z = x + y;
            return z;
        }

        /// <summary>
        /// Metod för att använda på en text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string VändText(string text)
        {
            //...
            string resultat = ..

            return resultat;
        }
    }
}
