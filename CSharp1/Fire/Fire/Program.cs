// Your task is to print on the console a torch of fire with width N
using System;

namespace Fire
{
    class Program
    {
        static void Main()
        {
            int n = byte.Parse(Console.ReadLine());

            //top part

            int outerDots = (n / 2) - 1;
            int innerDots = 0;

            for (int i = 0; i < n / 2; i++)
            {

                Console.Write(new string('.', outerDots));
                Console.Write("#");
                Console.Write(new string('.', innerDots));
                Console.Write("#");
                Console.Write(new string('.', outerDots));

                outerDots--;
                innerDots += 2;

                Console.WriteLine();
            }

            outerDots = 0;
            innerDots = n - 2;

            for (int j = 0; j < ((n / 2) / 2); j++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write("#");
                Console.Write(new string('.', innerDots));
                Console.Write("#");
                Console.Write(new string('.', outerDots));

                outerDots++;
                innerDots -= 2;

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', n));

            outerDots = 0;
            int lines = n / 2;

            for (int k = 0; k < n / 2; k++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write(new string('\\', lines));
                Console.Write(new string('/', lines));
                Console.Write(new string('.', outerDots));

                outerDots++;
                lines--;

                Console.WriteLine();
            }
        }
    }
}