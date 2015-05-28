//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter the array items count: ");
        int n = int.Parse(Console.ReadLine());

        bool[] myArray = new bool[n];

        for (int i = 2; i < n; i++)
        {
            myArray[i] = true;
        }


        int nSqrt = (int)Math.Sqrt(n);

        for (int j = 2; j <= nSqrt; j++)
        {
            for (int k = j*j; k < n; k += j)
            {
                myArray[k] = false;
            }
        }

        Console.WriteLine("Prime numbers are:");

        for (int i = 0; i < n; i++)
        {
            if (myArray[i])
            {
                Console.Write("{0} ",i);
            }
        }



    }
}

