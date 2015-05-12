using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radius;

        public double CalculateDiametre()
        {
            return 2 * radius;
        }

        public double CalculatePerimetre()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
