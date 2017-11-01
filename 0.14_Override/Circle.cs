using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Circle : Shape
    {
        // Constructor
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        // Properties
        public double Radius { get; set; }

        // Methods
        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
