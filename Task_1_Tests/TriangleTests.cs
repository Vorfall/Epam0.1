using System;
using Xunit;
using Task1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetAreaTriangle1()
        {
            var sidesList = new List<double> { 6, 8, 6 };
            var triangle = new Task1.Triangle(sidesList);
            double result = triangle.GetArea();
            double actualResult = 17.88854381999832;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetAreaTriangle2()
        {
            var sidesList = new List<double> { 1, 1, 1 };
            var triangle = new Task1.Triangle(sidesList);
            double result = triangle.GetArea();
            double actualResult = 0.4330127018922193;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrTriangle1()
        {
            var sidesList = new List<double> { 6, 8, 6 };
            var triangle = new Task1.Triangle(sidesList);
            double result = triangle.GetPerimeter();
            double actualResult = 20;
            Assert.Equal(actualResult, result);

        }

        [Fact]
        public void GetPerimetrTriangle2()
        {
            var sidesList = new List<double> { 1, 1, 1 };
            var triangle = new Task1.Triangle(sidesList);
            double result = triangle.GetPerimeter();
            double actualResult = 3;
            Assert.Equal(actualResult, result);

        }

        //[Fact]
        //public void GetTotalPerimetrTriangle1()
        //{
        //    var sidesList1 = new List<double> { 1, 1, 1 };
        //    var sidesList2 = new List<double> { 2, 2, 2 };
        //    var sidesList3 = new List<double> { 3, 3, 3 };
        //    var
        //    var triangle1 = new Task1.Triangle(sidesList1);
        //    var triangle2 = new Task1.Triangle(sidesList2);
        //    var triangle3 = new Task1.Triangle(sidesList3);
        //    double result = GetTotaltPerimeter();
        //    double actualResult = 3;
        //    Assert.Equal(actualResult, result);

        //}


    }
}
