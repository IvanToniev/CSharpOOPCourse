using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01_3DPoint
{
    public static class PathStorage
    {
        public static void SavePath(Path path) 
        {
            using (StreamWriter writer = new StreamWriter(@"../../SavedPaths.txt"))
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static List<Path> LoadPath()
        {
            Path loadPath = new Path();
            List<Path> pathsLoaded = new List<Path>();
            using (StreamReader reader = new StreamReader(@"../../LoadedPaths.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line != "-")
                    {
                        Point point = new Point();
                        string[] points = line.Split(',');
                        point.X = int.Parse(points[0]);
                        point.Y = int.Parse(points[1]);
                        point.Z = int.Parse(points[2]);
                        loadPath.AddPoint(point);
                    }
                    else
                    {
                        pathsLoaded.Add(loadPath);
                        loadPath = new Path();
                    }
                    line = reader.ReadLine();
                }
            }
            return pathsLoaded;
        }
       
    }   
}
