using System;
using System.IO;

namespace Filhantering3
{
    class Program
    {
        static void Main(string[] args)
        {
            string  filePath = @"C:\Demos\Text.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
