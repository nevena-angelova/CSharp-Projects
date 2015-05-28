using System;

namespace BinaryPasswords
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            long result = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    result *= 2;
                }
            }

            Console.WriteLine(result);
        }
    }
}