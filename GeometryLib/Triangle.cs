using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Triangle: Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        private bool isRight
        {
            get
            {
                if (A > B && A > C)
                    return A * A == B * B + C * C;
                else if (B > A && B > C)
                    return B * B == A * A + C * C;
                else if (C > A && C > B)
                    return C * C == A * A + B * B;
                else
                    return false;
            }
        }

        private double halfOfPerimeter
        {
            get { return (A + B + C)/2; }
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника не могут быть меньше или равны 0");
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            if (isRight)
                return RightTraingleArea();
            else
                return GeronArea();
        }

        private double GeronArea()
        {
            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - A) * (halfOfPerimeter - B) * (halfOfPerimeter - C));
        }

        private double RightTraingleArea()
        {
            if (A > B && A > C)
                return B * C * 0.5;
            else if (B > A && B > C)
                return A * C * 0.5;
            else 
                return A * B * 0.5;
        }
    }
}
