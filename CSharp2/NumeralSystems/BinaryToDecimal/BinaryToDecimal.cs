// Write a program to convert binary numbers to their decimal representation.
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number");
        int num = int.Parse(Console.ReadLine());
        int power = 0;
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10 * (int)Math.Pow(2, power);
            num /= 10;
            power++;
        }

        Console.WriteLine(sum);
    }
}

