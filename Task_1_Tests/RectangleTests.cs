using System;
using Xunit;
using Task1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Tests
{
    public class RectangleTests
    {
        [Fact]
        public void GetAreaRectangle1()
        {
            var sidesList = new List<double> { 6, 8, 6, 4 };
            var Rectangle = new Task1.Rectangle(sidesList);
            double result = Rectangle.GetArea();
            double actualResult = 48;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetAreaRectangle2()
        {
            var sidesList = new List<double> { 1, 1, 1, 1 };
            var Rectangle = new Task1.Rectangle(sidesList);
            double result = Rectangle.GetArea();
            double actualResult = 1;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrRectangle1()
        {
            var sidesList = new List<double> { 6, 8, 6, 8 };
            var Rectangle = new Task1.Rectangle(sidesList);
            double result = Rectangle.GetPerimeter();
            double actualResult = 28;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrRectangle2()
        {
            var sidesList = new List<double> { 1, 1, 1, 1 };
            var Rectangle = new Task1.Rectangle(sidesList);
            double result = Rectangle.GetPerimeter();
            double actualResult = 4;
            Assert.Equal(actualResult, result);

        }
    }
}
