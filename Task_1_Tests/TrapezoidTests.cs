using System;
using Xunit;
using Task1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Tests
{
    public class TrapezoidTests
    {
        [Fact]
        public void GetAreaTrapezoid1()
        {
            var sidesList = new List<double> { 1, 2, 3, 2 };
            var Trapezoid = new Task1.Trapezoid(sidesList);
            double result = Trapezoid.GetArea();
            double actualResult = 3.4641016151377544;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetAreaTrapezoid2()
        {
            var sidesList = new List<double> { 1, 2, 4, 2 };
            var Trapezoid = new Task1.Trapezoid(sidesList);
            double result = Trapezoid.GetArea();
            double actualResult = 3.9528470752104745;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrTrapezoid1()
        {
            var sidesList = new List<double> { 1, 2, 3, 2 };
            var Trapezoid = new Task1.Trapezoid(sidesList);
            double result = Trapezoid.GetPerimeter();
            double actualResult = 8;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrTrapezoid2()
        {
            var sidesList = new List<double> { 1, 2, 4, 2 };
            var Trapezoid = new Task1.Trapezoid(sidesList);
            double result = Trapezoid.GetPerimeter();
            double actualResult = 9;
            Assert.Equal(actualResult, result);

        }
    }
}
