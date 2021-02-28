using System;

namespace FigureSquares
{
    abstract class Figure
    {
        public abstract double Square();

    }

    class Circle : Figure
    {
        public double R { get; set; }
        public override double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }

    class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
