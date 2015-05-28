// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMax
{
    static void Main()
    {
        Console.Write("number 1 = ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("number 2 = ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("number 3 = ");
        int num3 = int.Parse(Console.ReadLine());

        int max = Max(Max(num1, num2), num3);

        Console.WriteLine(max);
    }

    static int Max(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }
}

