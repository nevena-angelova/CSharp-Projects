using System;
using System.Text;

namespace PointsDistanceAndPaths
{
    public struct Point3D
    {
        // (ex. 1)

        private double x;
        private double y;
        private double z;

        // (ex. 2)

        private static readonly Point3D zero = new Point3D(0, 0, 0);

        public static Point3D Zero
        {
            get { return zero; }
        }

        // (ex. 1)

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // (ex. 1)

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("x = " + this.x + ", ");
            result.Append("y = " + this.y + ", ");
            result.Append("z = " + this.z);

            return result.ToString();
        }
    }
}
