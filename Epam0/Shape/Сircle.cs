using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Сircle
    {
        public Сircle(List<double> sidesCollection)
        {
            if (sidesCollection.Count() != 1)
            {
                throw new ArgumentException("The count of sides is not equal to two or four.", "sides");
            }

            Sides = sidesCollection.ToList();
        }
        public List<double> Sides { get; set; }
        public string TypeFigure { get; set; }

        public double GetArea() => (3.14 * Math.Pow(Sides[0], 2));

        public double GetPerimeter() => ((3.14 * Sides[0]) * 2);

    }
}
