using System;

namespace Prov_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut din lön");
            Console.WriteLine("Vi börjar med att räkna ut din marginalskatt med hjälp av din bruttolön");
            Console.WriteLine("Mata in din bruttolön i (kr)");
            int kr = int.Parse(Console.ReadLine());

            if (kr < 10000)
            {
                Console.WriteLine("Din marginalskatt är 8%!");
            }

            else if (kr >= 10000 && kr < 145000)
            {
                Console.WriteLine("Din marginalskatt är 22%!");
            }

            else if (kr >= 145000 && kr < 515000)
            {
                Console.WriteLine("Din marginalskatt är 33%");
            }
            
            else
            {
                Console.WriteLine("Din marginal skatt är 53%");
            }

            Console.WriteLine("Nu räknar vi ut din nettolön men hjälp utav din marginalskatt");
            Console.WriteLine("Skriv in din marginalskatt sedan din bruttolön");
            int marginalskatt = int.Parse(Console.ReadLine());
            int bruttolön = int.Parse(Console.ReadLine());
            int tal1 = 100 - marginalskatt;
            int nettolön = bruttolön * tal1/100;
            Console.WriteLine("Din nettoön är " + nettolön + "kr.");

            Console.WriteLine("Vill du fortsätta räkna?");
            Console.WriteLine("1 = ja, 2 = nej");
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    Console.WriteLine("Glömde bort hur man loopar plus har inet tid");
                    break;

                case "2":
                    Console.WriteLine("Ha en trvlig dag");
                    break;

        }
    }
    }
}