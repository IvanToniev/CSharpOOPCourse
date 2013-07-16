using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shape
{
    public abstract class Shape
    {
       
        public Shape(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public Shape(double width)
            
        {
            this.Width = width;
        }

        public double Height
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public abstract double CalculateSurface();
    }
}
