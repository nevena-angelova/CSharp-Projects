// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
using System;

class SumFibonacci
{
    static void Main()
    {
        ulong prev2 = 1;
        ulong prev1 = 0;
        ulong num = 0; ;
        ulong prevNum = 0;

        Console.Write("Enter a number for N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("0");

        if (n > 1)
        {
            for (uint i = 1; i < n; i++)
            {
                num = prev1 + prev2;
                prev2 = prev1;
                prev1 = num;

                Console.Write(" + {0}", num);

                num += prevNum;
                prevNum = num;
            }
        }

        Console.WriteLine(" = {0}", num);

    }
}

