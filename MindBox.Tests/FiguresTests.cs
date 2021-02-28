using FigureSquares;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MindBox.Tests
{
    public class FiguresTests
    {
        [Fact]
        public void SquareTest()
        {
            Circle circle = new Circle { R = 4 };

            var circleSquare = circle.Square();

            //Assert
        }
    }
}
