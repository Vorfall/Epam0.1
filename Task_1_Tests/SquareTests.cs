using System;
using Xunit;
using Task1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Tests
{
    public class SquareTests
    {
        [Fact]
        public void GetAreaSquare1()
        {
            var sidesList = new List<double> { 6, 6 };
            var Square = new Task1.Square(sidesList);
            double result = Square.GetArea();
            double actualResult = 36;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetAreaSquare2()
        {
            var sidesList = new List<double> { 1, 1 };
            var Square = new Task1.Square(sidesList);
            double result = Square.GetArea();
            double actualResult = 1;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrSquare1()
        {
            var sidesList = new List<double> { 6, 8 };
            var Square = new Task1.Square(sidesList);
            double result = Square.GetPerimeter();
            double actualResult = 28;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrSquare2()
        {
            var sidesList = new List<double> { 1, 1 };
            var Square = new Task1.Square(sidesList);
            double result = Square.GetPerimeter();
            double actualResult = 4;
            Assert.Equal(actualResult, result);

        }
    }
}
