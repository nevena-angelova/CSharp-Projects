// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class DigitCheck
{
    static void Main()
    {
        Console.Write("Enter a number from 1000 to 9999: ");
        int number = int.Parse(Console.ReadLine());

        bool isDigit = number / 100 % 10 == 7;

        Console.WriteLine("The 3-rd digit is 7: {0}", isDigit);
    }
}

