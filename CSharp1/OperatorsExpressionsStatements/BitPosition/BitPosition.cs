// Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit number (0-31): ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;

        int result = i & mask;

        string bitValue = result >> b == 1 ? "1" : "0";

        Console.WriteLine("In {0} (" + Convert.ToString(i, 2).PadLeft(32, '0') + ") the value of bit {1} is {2}", i, b, bitValue);
    }
}

