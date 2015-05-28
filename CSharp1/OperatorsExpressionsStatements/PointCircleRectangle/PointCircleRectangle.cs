// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;

    class PointCircleRectangle
    {
        static void Main()
        {
            Console.Write("Enter X coordinate: ");
            decimal pointX = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            decimal pointY = decimal.Parse(Console.ReadLine());

            decimal radius = 3;

            decimal poinDistance = (pointX-1) * (pointX-1) + (pointY-1) * (pointY-1);

            bool isInCir = poinDistance < radius * radius;

            bool isInRect = pointY > -1 && pointY < 1 && pointX > -1 && pointX < 5;

            bool isInCirRect = isInCir & isInRect;

            Console.WriteLine("The point is in the circle: {0}", isInCir);
            Console.WriteLine("The point is in the rectangle: {0}", isInRect);
            Console.WriteLine("The point is in the circle and the rectangle: {0}", isInCirRect);


        }
    }

