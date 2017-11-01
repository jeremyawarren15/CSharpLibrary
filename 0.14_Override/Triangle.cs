using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Triangle : Shape
    {
        // Constants
        const double NUM_SIDES = 3;

        // Constructors
        public Triangle(double baseLength, double height)
        {
            this.Base = baseLength;
            this.Height = height;
        }

        // Properties
        public double Base { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return (Base * Height) / 2;
        }

    }
}
