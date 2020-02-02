using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Circle: Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
