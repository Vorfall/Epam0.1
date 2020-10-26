using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class СomparisonPerimeter
    {
        public double GetTotalPerimeterTriangle(Triangle[] triangl)
        {
            double totalPerimeter = 0;

            for (var i = 0; i < 3; i++)
            {
                totalPerimeter += triangl[i].GetPerimeter();
            }

            return totalPerimeter;
        }

        public double GetTotalPerimeterRectangle(Rectangle[] rectangle)
        {
            double totalPerimeter = 0;

            for (var i = 0; i < 3; i++)
            {
                totalPerimeter += rectangle[i].GetPerimeter();
            }

            return totalPerimeter;
        }

        public double GetTotalPerimeterSquare(Square[] square)
        {
            double totalPerimeter = 0;

            for (var i = 0; i < 3; i++)
            {
                totalPerimeter += square[i].GetPerimeter();
            }

            return totalPerimeter;
        }

        public double GetTotalPerimeterTrapezoid(Trapezoid[] trapezoid)
        {
            double totalPerimeter = 0;

            for (var i = 0; i < 3; i++)
            {
                totalPerimeter += trapezoid[i].GetPerimeter();
            }

            return totalPerimeter;
        }

        public double GetTotalPerimeterСircle(Сircle[] circle)
        {
            double totalPerimeter = 0;

            for (var i = 0; i < 3; i++)
            {
                totalPerimeter += circle[i].GetPerimeter();
            }

            return totalPerimeter;
        }

        public double GetAveragePerimeterСircle(Сircle[] circle) => (GetTotalPerimeterСircle(circle) / 3);
        public double GetAveragePerimeterTriangle(Triangle[] triangle) => (GetTotalPerimeterTriangle(triangle) / 3);
        public double GetAveragePerimeterRectangle(Rectangle[] rectangle) => (GetTotalPerimeterRectangle(rectangle) / 3);
        public double GetAveragePerimeterSquare(Square[] square) => (GetTotalPerimeterSquare(square) / 3);
        public double GetAveragePerimeterTrapezoid(Trapezoid[] trapezoid) => (GetTotalPerimeterTrapezoid(trapezoid) / 3);

        public string GetMaxAveragePerimeter(Сircle[] circle, Triangle[] triangle, Rectangle[] rectangle, Square[] square, Trapezoid[] trapezoid)
        {
            string nameTypeMaxFigure = "Triangle";
            double maxPerimeter = GetAveragePerimeterTriangle(triangle);

            if (maxPerimeter == GetAveragePerimeterСircle(circle)) { nameTypeMaxFigure = nameTypeMaxFigure + "and Сircle"; }
            if (maxPerimeter < GetAveragePerimeterСircle(circle)) { nameTypeMaxFigure = "Сircle"; maxPerimeter = GetAveragePerimeterСircle(circle); }

            if (maxPerimeter == GetAveragePerimeterRectangle(rectangle)) { nameTypeMaxFigure = nameTypeMaxFigure + "and rectangle"; }
            if (maxPerimeter < GetAveragePerimeterRectangle(rectangle)) { nameTypeMaxFigure = "rectangle"; maxPerimeter = GetAveragePerimeterRectangle(rectangle); }

            if (maxPerimeter == GetAveragePerimeterSquare(square)) { nameTypeMaxFigure = nameTypeMaxFigure + "and square"; }
            if (maxPerimeter < GetAveragePerimeterSquare(square)) { nameTypeMaxFigure = "square"; maxPerimeter = GetAveragePerimeterSquare(square); }

            if (maxPerimeter == GetAveragePerimeterTrapezoid(trapezoid)) { nameTypeMaxFigure = nameTypeMaxFigure + "and trapezoid"; }
            if (maxPerimeter < GetAveragePerimeterTrapezoid(trapezoid)) { nameTypeMaxFigure = "trapezoid"; maxPerimeter = GetAveragePerimeterTrapezoid(trapezoid); }
            return nameTypeMaxFigure;
        }
    }
}
