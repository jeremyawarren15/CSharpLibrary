using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Triangle : Shape
    {
        // Constructors
        public Triangle(int tBase, int height)
        {
            this.TBase = tBase;
            this.Height = height;
            this.TArea = this.Area();
        }

        // Properties
        public int TBase { get; set; }
        public int Height { get; set; }
        public double TArea { get; set; }

        // Methods
        public override double Area()
        {
            this.TArea = (this.Height * this.TBase) / 2.0;
            return this.TArea;
        }
    }
}
