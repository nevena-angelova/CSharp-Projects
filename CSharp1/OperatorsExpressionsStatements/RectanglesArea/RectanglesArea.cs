// Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectanglesArea
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for b: ");
        int b = int.Parse(Console.ReadLine());

        int area = a * b;

        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}

