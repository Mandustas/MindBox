using System;
using System.Collections.Generic;

namespace FigureSquares
{
    public abstract class Figure
    {
        public abstract double Square();

    }

    public class Circle : Figure
    {
        public double R { get; set; }
        public override double Square()
        {
            if (R<0)
            {
                throw new ArgumentException("Значение радиуса не может быть меньше нуля!");
            }
            return Math.PI * Math.Pow(R, 2);
        }
    }

    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override double Square()
        {
            List<double> sides = new List<double>();
            sides.Add(A);
            sides.Add(B);
            sides.Add(C);
            sides.Sort();

            if (!(A + B > C && A + C > B && B + C > A)) //Треугольник существует?
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует!");
                
            }


            if ((Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2)) == Math.Pow(sides[2], 2)) // Треугольник прямоугольный?
            {
                return (sides[1] * sides[0]) / 2;
            }
            else
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
