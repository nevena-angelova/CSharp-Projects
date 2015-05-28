// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;
using System.Numerics;

class FactorialExpression
{
    static void Main()
    {
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger kResultFactorial = 1;
        BigInteger nFactorial = 1;
        BigInteger result = 1;

        if (k > n)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (int j = (k - n + 1); j <= k; j++)
            {
                kResultFactorial *= j;
            }

            result = kResultFactorial * nFactorial;
        }
        else
        {
            Console.WriteLine("K needs to be bigger than N!");
        }

        Console.WriteLine(result);
    }
}

