// Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        float h = float.Parse(Console.ReadLine());
        float area = (a + b) / 2 * h;
        Console.WriteLine("The trapezoid area is: {0}", area);
    }
}

