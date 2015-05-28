// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;

class FormatOutput
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D}", num);
        Console.WriteLine("{0,15:X}", num);
        Console.WriteLine("{0,15:P}", num);
        Console.WriteLine("{0,15:E}", num);
    }
}

