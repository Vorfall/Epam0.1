using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class СomparisonArea
    {
        public double GetTotalAreaTriangle(Triangle[] triangl)
        {
            double totalArea = 0;

            for (var i = 0; i < 3; i++)
            {
                totalArea += triangl[i].GetArea();
            }

            return totalArea;
        }

        public double GetTotalAreaRectangle(Rectangle[] rectangle)
        {
            double totalArea = 0;

            for (var i = 0; i < 3; i++)
            {
                totalArea += rectangle[i].GetArea();
            }

            return totalArea;
        }

        public double GetTotalAreaSquare(Square[] square)
        {
            double totalArea = 0;

            for (var i = 0; i < 3; i++)
            {
                totalArea += square[i].GetArea();
            }

            return totalArea;
        }

        public double GetTotalAreaTrapezoid(Trapezoid[] trapezoid)
        {
            double totalArea = 0;

            for (var i = 0; i < 3; i++)
            {
                totalArea += trapezoid[i].GetArea();
            }

            return totalArea;
        }

        public double GetTotalAreaСircle(Сircle[] circle)
        {
            double totalArea = 0;

            for (var i = 0; i < 3; i++)
            {
                totalArea += circle[i].GetArea();
            }

            return totalArea;
        }

        public double GetAverageAreaСircle(Сircle[] circle) => (GetTotalAreaСircle(circle) / 3);
        public double GetAverageAreaTriangle(Triangle[] triangle) => (GetTotalAreaTriangle(triangle) / 3);
        public double GetAverageAreaRectangle(Rectangle[] rectangle) => (GetTotalAreaRectangle(rectangle) / 3);
        public double GetAverageAreaSquare(Square[] square) => (GetTotalAreaSquare(square) / 3);
        public double GetAverageAreaTrapezoid(Trapezoid[] trapezoid) => (GetTotalAreaTrapezoid(trapezoid) / 3);

        public string GetMaxAverageArea(Сircle[] circle, Triangle[] triangle, Rectangle[] rectangle, Square[] square, Trapezoid[] trapezoid)
        {
            string nameTypeMaxFigure = "Triangle";
            double maxArea = GetTotalAreaTriangle(triangle);

            if (maxArea == GetAverageAreaСircle(circle)) { nameTypeMaxFigure = nameTypeMaxFigure + "and Сircle"; }
            if (maxArea < GetAverageAreaСircle(circle)) { nameTypeMaxFigure = "Сircle"; maxArea = GetAverageAreaСircle(circle); }

            if (maxArea == GetAverageAreaRectangle(rectangle)) { nameTypeMaxFigure = nameTypeMaxFigure + "and rectangle"; }
            if (maxArea < GetAverageAreaRectangle(rectangle)) { nameTypeMaxFigure = "rectangle"; maxArea = GetAverageAreaRectangle(rectangle); }

            if (maxArea == GetAverageAreaSquare(square)) { nameTypeMaxFigure = nameTypeMaxFigure + "and square"; }
            if (maxArea < GetAverageAreaSquare(square)) { nameTypeMaxFigure = "square"; maxArea = GetAverageAreaSquare(square); }

            if (maxArea == GetAverageAreaTrapezoid(trapezoid)) { nameTypeMaxFigure = nameTypeMaxFigure + "and trapezoid"; }
            if (maxArea < GetAverageAreaTrapezoid(trapezoid)) { nameTypeMaxFigure = "trapezoid"; maxArea = GetAverageAreaTrapezoid(trapezoid); }
            return nameTypeMaxFigure;
        }
    }


}
