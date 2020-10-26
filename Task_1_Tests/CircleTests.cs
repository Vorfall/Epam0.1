using System;
using Xunit;
using Task1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Tests
{
    public class —ircleTests
    {
        [Fact]
        public void GetArea—ircle1()
        {
            var sidesList = new List<double> { 6 };
            var —ircle = new Task1.—ircle(sidesList);
            double result = —ircle.GetArea();
            double actualResult = 113.04;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetArea—ircle2()
        {
            var sidesList = new List<double> { 1 };
            var —ircle = new Task1.—ircle(sidesList);
            double result = —ircle.GetArea();
            double actualResult = 3.14;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetr—ircle1()
        {
            var sidesList = new List<double> { 6 };
            var —ircle = new Task1.—ircle(sidesList);
            double result = —ircle.GetPerimeter();
            double actualResult = 37.68;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetr—ircle2()
        {
            var sidesList = new List<double> { 1 };
            var —ircle = new Task1.—ircle(sidesList);
            double result = —ircle.GetPerimeter();
            double actualResult = 6.28;
            Assert.Equal(actualResult, result);

        }
    }
}
