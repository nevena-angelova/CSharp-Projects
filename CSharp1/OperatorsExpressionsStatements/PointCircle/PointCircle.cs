// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
using System;

class PointCircle
{
    static void Main()
    {
        Console.Write("Enter X coordinate: ");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        decimal pointY = decimal.Parse(Console.ReadLine());

        int radius = 5;
        decimal poinDistance = pointX * pointX + pointY * pointY;

        bool isInCircle = poinDistance < radius * radius;

        Console.WriteLine("The point is in the circle: {0}", isInCircle);
    }
}

