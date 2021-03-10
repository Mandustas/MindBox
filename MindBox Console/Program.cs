using System;
using FigureSquares;

namespace MindBox_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle { R = -4 };
                Console.WriteLine("Circle square is: " + circle.Square());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Triangle triangle = new Triangle { A = 0, B = 5, C = 10 };
                Console.WriteLine("Triangle square is: " + triangle.Square());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
