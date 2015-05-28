// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        double n = int.Parse(Console.ReadLine());

        double f1 = 1;
        double f2 = 1;

        // (2n)!/(n+1)!n! is 2n!/(n+1)n!n!

        for (double i = 1, j = 1; j <= (2 * n); i++, j++)
        {
            if (i <= n)
            {
                f1 *= i;
            }

            f2 *= j;
        }

        double result = f2 / ((n + 1) * f1 * f1);

        Console.WriteLine("The N-th Catalan number is: {0}", result);
    }
}


