//Write an expression that checks if given integer is odd or even.

using System;

class OddEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isEven = number % 2 == 0;

        Console.WriteLine("Even number: {0}", isEven);
    }
}
