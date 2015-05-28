// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
using System;

class DevidedByNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDevided = number % 5 == 0 && number % 7 == 0;

        Console.WriteLine("The number is devided by 5 and 7: {0}", isDevided);
    }
}

