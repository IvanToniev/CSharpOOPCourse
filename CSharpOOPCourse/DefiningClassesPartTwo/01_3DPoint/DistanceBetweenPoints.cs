using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3DPoint
{
    public static class DistanceBetweenPoints
    {
        public static double DistanceBetweenPointsCalculator(Point PointOne,Point PointTwo) 
        {
            double xResult = PointOne.X - PointTwo.X;
            double yResult = PointOne.Y - PointTwo.Y;
            double zResult = PointOne.Z - PointTwo.Z;
            return Math.Sqrt(xResult*xResult+yResult*yResult+zResult*zResult);
        }
    }
}
