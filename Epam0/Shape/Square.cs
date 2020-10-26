using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Square
    {
        public Square(List<double> sidesCollection)
        {
            if (sidesCollection.Count() != 2 && sidesCollection[0] == sidesCollection[2] && sidesCollection[0] == sidesCollection[1] && sidesCollection[1] == sidesCollection[3])
            {
                throw new ArgumentException("The count of sides is not equal to two or four.", "sides");
            }

            Sides = sidesCollection.ToList();
        }
        public List<double> Sides { get; set; }

        public string TypeFigure { get; set; }

        public double GetArea() => (Math.Pow(Sides[0], 2));

        public double GetPerimeter() => ((Sides[0] + Sides[1]) * 2);

    }
}
