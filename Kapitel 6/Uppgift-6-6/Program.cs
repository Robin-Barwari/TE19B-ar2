using System;

namespace Uppgift_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Multiplikation------");
            Console.WriteLine($"15*6 = {Multiplicera(15, 6)}");

            Console.WriteLine("---------Dividera---------");
            Console.WriteLine($"465/34 = {Dividera(465, 34)}");
        }

        static double Multiplicera(double tal1, double tal2)
        {
            return tal1 * tal2;
        }

        static double Dividera(double tal1, double tal2)
        {
            return tal1 / tal2;
        }
    }
}
