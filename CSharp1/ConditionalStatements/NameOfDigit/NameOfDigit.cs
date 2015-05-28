// Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
using System;

class NameOfDigit
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a digit: ");
        int digitEntered = int.Parse(Console.ReadLine());

        string digit;

        switch (digitEntered)
        {
            case 0: digit = "zero"; break;
            case 1: digit = "one"; break;
            case 2: digit = "two"; break;
            case 3: digit = "three"; break;
            case 4: digit = "four"; break;
            case 5: digit = "five"; break;
            case 6: digit = "six"; break;
            case 7: digit = "seven"; break;
            case 8: digit = "eight"; break;
            case 9: digit = "nine"; break;
            default: digit = "Error!"; break;
        }

        Console.WriteLine(digit);
    }
}

