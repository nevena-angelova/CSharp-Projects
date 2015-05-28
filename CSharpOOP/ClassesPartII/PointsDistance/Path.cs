using System;
using System.Collections.Generic;

namespace PointsDistanceAndPaths
{
    public class Path
    {
        private List<Point3D> pathsList = new List<Point3D>();
        
        public List<Point3D> PathsList
        {
            get { return this.pathsList; }
            set { this.pathsList = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.pathsList.Add(point);
        }

   }
}
