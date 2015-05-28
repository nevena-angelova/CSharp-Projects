using System;
using System.IO;

namespace PointsDistanceAndPaths
{
    public static class PathStorage
    {
        public static void LoadPaths(Path path)
        {
            StreamReader reader = new StreamReader("input.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                string[] coordStrArr;
                Point3D currentPoint;

                while (line != null)
                {
                    coordStrArr = line.Split(','); // gets the current line coordinates splitted by ','

                    // initialze a new point with parameters the int parsed coordStrArr items 

                    currentPoint = new Point3D(int.Parse(coordStrArr[0]), int.Parse(coordStrArr[1]), int.Parse(coordStrArr[2]));

                    path.AddPoint(currentPoint);

                    line = reader.ReadLine();
                }
            }
        }

        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter("output.txt");

            using (writer)
            {
                foreach (Point3D point in path.PathsList)
                {
                    writer.WriteLine(point.ToString());
                }
            }
        }
    }
}
