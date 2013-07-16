using System;
using System.Collections.Generic;
using System.Linq;


namespace _01_3DPoint
{
    public class Path
    {
        public readonly List<Point> PathHolder=new List<Point>();

        public List<Point> Paths
        {
            get
            {
                return this.PathHolder;
            }
        }

        public void AddPoint(Point point)
        {
            Paths.Add(point);
        }

        public void ClearPath() 
        {
            PathHolder.Clear();
        }
    }
}
