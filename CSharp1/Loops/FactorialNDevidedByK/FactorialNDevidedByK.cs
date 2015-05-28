// Write a program that calculates N!/K! for given N and K (1<K<N).
using System;

class FactorialNDevidedByK
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        if (n > k)
        {
            int result = 1;

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine("N!/K! = {0}!/{1}! = {2}", n, k, result);
        }
        else
        {
            Console.WriteLine("N needs to be bigger than K");
        }
    }
}

