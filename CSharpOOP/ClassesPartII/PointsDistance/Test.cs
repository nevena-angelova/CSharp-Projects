using System;

namespace PointsDistanceAndPaths
{
    class Test
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1, -2, 3);
            Point3D point2 = new Point3D(-1.5, 1, -2);

            // Calculate Distance test

            PrintCalcResult(point1, point2);
            PrintCalcResult(Point3D.Zero, point2);

            // AddPoint, SavePath, and LoadPath test

            Path myPath = new Path();

            PathStorage.LoadPaths(myPath);

            myPath.AddPoint(point1);
            myPath.AddPoint(point2);

            PathStorage.SavePath(myPath);
        }

        static void PrintCalcResult(Point3D p1, Point3D p2)
        {
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine("The distance is:");
            Console.WriteLine(PointsDistance.CalculateDistance(p1, p2));
            Console.WriteLine();
        }
    }

}