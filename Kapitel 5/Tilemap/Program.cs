using System;

namespace Tilemap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa labyrint
            int[,] labyrint = {     //new int[5,5]
                {1, 1, 1, 1, 1},    // y=0
                {0, 0, 0, 0, 1},    // y=1
                {1, 0, 1, 0, 1},    // y=2
                {1, 0, 1, 0, 0},    // y=3
                {1, 0, 1, 1, 1}     // y=4
            };

            Console.OutputEncoding = System.Text.Encoding.Default;

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (labyrint[y, x] == 1)
                    {
                        Console.Write('\u2B1C');
                    }
                    else
                    {
                        Console.Write('\u2B1B')
                    }

                    Console.Write(labyrint[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
