using FigureSquares;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MindBox.Tests
{
    public class CircleTests
    {

        [Fact]
        public void SquareTest()
        {
            Circle circle = new Circle { R = 4 };

            var circleSquare = circle.Square();

            //Assert
            Assert.Equal(50.265, Math.Round(circleSquare, 3));
        }
        [Fact]
        public void SquareZeroRTest()
        {
            Circle circle = new Circle { R = 0 };

            var circleSquare = circle.Square();

            //Assert
            Assert.Equal(0, circleSquare);
        }
        [Fact]
        public void SquareNotIntegerRTest()
        {
            Circle circle = new Circle { R = 1.5 };

            var circleSquare = circle.Square();

            //Assert
            Assert.Equal(7.069, Math.Round(circleSquare, 3));
        }
        [Fact]
        public void SquareNegativeRTest()
        {
            Circle circle = new Circle { R = -3 };

            //var circleSquare = circle.Square();

            //Assert
            Assert.Throws<ArgumentException>(() => circle.Square());
        }
    }
}
