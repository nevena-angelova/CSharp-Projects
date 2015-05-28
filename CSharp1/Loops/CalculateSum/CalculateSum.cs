// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter an integer for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer for X: ");
        int x = int.Parse(Console.ReadLine());

        decimal factorial = 1;
        decimal power = 1;
        decimal sum = 1;

        Console.Write("S = 1 ");

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += factorial / power;

            Console.Write("+ {0}!/{1}^{0} ", i, x);
        }

        Console.Write(" = {0}", sum);

        Console.WriteLine();

    }
}

