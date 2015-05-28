// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
using System;

class BitPositionCheck1
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter a position (0-31): ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
    
        int result = num & mask;

        bool isOne = result >> p == 1;

        Console.WriteLine("In {0} (" + Convert.ToString(num, 2).PadLeft(32, '0') + ") the bit at position {1} is 1: {2}", num, p, isOne);
    }
}

