// Write a method that returns the last digit of given integer as an English word.
// Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigitToNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int digit = int.Parse(Console.ReadLine());

        LastDigitAsWord(digit);
    }

    static void LastDigitAsWord(int digit)
    {
        int lastDigit = Math.Abs(digit % 10); // works with negative numbers

        switch (lastDigit)
        {
            case 0: Console.WriteLine("zero"); break;
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("tree"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            default: break;
        }
    }
}

