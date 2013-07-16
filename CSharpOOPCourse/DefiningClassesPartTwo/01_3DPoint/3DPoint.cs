using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_3DPoint
{
    public struct Point
    {
        private double x, y, z;
        private static readonly Point coordSystemStart = new Point(0,0,0);

        public static Point ZeroPoint
        {
            get { return coordSystemStart; }
        }

        public double X
        {
            get{return this.x;}
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

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return String.Format("Point coordinates: x={0}, y={1}, z={2}",x,y,z);
        }
    }

    class DistanceTest
    {
        static void Main(string[] args)
        {
            Point somePoint=new Point(3,4,5);
            Point someOtherPoint = new Point(5,6,7);
            Console.WriteLine(somePoint.ToString());
            Console.WriteLine(Point.ZeroPoint.ToString());
            Console.WriteLine(DistanceBetweenPoints.DistanceBetweenPointsCalculator(somePoint,someOtherPoint));
        }
    }
}
