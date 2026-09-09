using System;

namespace task8
{
    internal abstract class GeometricShape
    {
        public double Dimension1 { get; set; }

        public double Dimension2 { get; set; }


        public abstract double CalculateArea();


        public abstract double Perimeter { get; }
    }


    internal class Triangle : GeometricShape
    {

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }
        public override double Perimeter
        {
            get
            {
                return 0;
            }
        }
    }


    internal class Rectangle1 : GeometricShape
    {

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }


        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }
    }
}
