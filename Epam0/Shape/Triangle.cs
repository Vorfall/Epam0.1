using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle
    {
        public Triangle(List<double> sidesCollection)
        {
            if (sidesCollection.Count() != 3)
            {
                throw new ArgumentException("The count of sides is not equal to two or four.", "sides");
            }

            Sides = sidesCollection.ToList();
        }
        public List<double> Sides { get; set; }

        public string TypeFigure { get; set; }

        public double GetArea()
        {
            double s, p;
            p = (Sides[0] + Sides[1] + Sides[2]) / 2;
            s = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            return s;
        }

        public double GetPerimeter() => (Sides[0] + Sides[1] + Sides[2]);

    }
}
