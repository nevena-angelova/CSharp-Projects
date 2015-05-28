// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number from 1 to 100: ");

        int number = int.Parse(Console.ReadLine());
        
        if (number == 1)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            for (byte i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (number == i)
                    {
                        Console.WriteLine("Prime", number);
                    }
                    else
                    {
                        Console.WriteLine("Not prime", number);
                        return;
                    }
                }
            }

        }

    }
}

