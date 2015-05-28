// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

using System;
using System.Numerics;

class Zeros
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int zeros = 0;
        int k = 5;
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("{0}! = {1}", n, factorial);

        while ((n / k) > 0)
        {
            zeros += n / k;
            k *= 5;
        }

        Console.WriteLine("The trailing zeros are: {0}", zeros);
    }
}

