
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    public class Trapezoid
    {
        public Trapezoid(List<double> sidesCollection)
        {
            if (sidesCollection.Count() != 4)
            {
                throw new ArgumentException("The count of sides is not equal to two or four.", "sides");
            }

            Sides = sidesCollection.ToList();
        }
        public List<double> Sides { get; set; }
        public string TypeFigure { get; set; }

        public double GetArea() => ((Sides[0] + Sides[2]) / 2) * Math.Sqrt(Math.Pow(Sides[3], 2) - (Math.Pow((Sides[2] - Sides[0]), 2) + Math.Pow(Sides[3], 2) - Math.Pow(Sides[1], 2)) / (2 * (Sides[2] - Sides[0])));

        public double GetPerimeter() => (Sides[0] + Sides[1] + Sides[2] + Sides[3]);


    }
}
