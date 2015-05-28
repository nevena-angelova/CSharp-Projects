// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
        }
    }

    static BigInteger Factorial(int j)
    {
        BigInteger factorialN = 1;

        for (int i = 1; i <= j; i++)
        {
            factorialN *= i;  
        }

        return factorialN;
    }
}

