using FigureSquares;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace MindBox.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleTest()
        {
            Triangle triangle = new Triangle { A = 8, B = 6, C = 4 };

            var triangleSquare = triangle.Square();

            //Assert
            Assert.Equal(11.619, Math.Round(triangleSquare, 3));
        }
        [Fact]
        public void TriangleNotIntegerSideTest()
        {
            Triangle triangle = new Triangle { A = 8.3, B = 6.1, C = 4 };

            var triangleSquare = triangle.Square();

            //Assert
            Assert.Equal(11.553, Math.Round(triangleSquare,3));
        }

        [Fact]
        public void TriangleZeroSideTest()
        {
            Triangle triangle = new Triangle { A = 8, B = 6, C = 0 };

            //var triangleSquare = triangle.Square();

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.Square());
        }

        [Fact]
        public void TriangleNegativeSideTest()
        {
            Triangle triangle = new Triangle { A = 8, B = 6, C = -4 };

            //var triangleSquare = triangle.Square();

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.Square());
        }

        [Fact]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle { A = 3, B = 4, C = 5 };

            var triangleSquare = triangle.Square();

            //Assert
            Assert.Equal(6, triangleSquare);
        }

        [Fact]
        public void TriangleExistExeptionTest()
        {
            Triangle triangle = new Triangle { A = 1, B = 2, C = 3 };

            //var triangleSquare = triangle.Square();

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.Square());
        }


    }
}
