using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Triangle : Shape
    {
        // Backing Fields
        private double _tBase;
        private double _tHeight;

        // Constructors
        public Triangle(int tBase, int height)
        {
            this.TBase = tBase;
            this.THeight = height;
            this.TArea = this.Area();
        }

        // Properties
        public double TBase
        {
            get { return _tBase; }
            set
            {
                this.Area();
                _tBase = value;
            }
        }
        public double THeight
        {
            get { return _tHeight; }
            set
            {
                this.Area();
                _tHeight = value;
            }
        }
        public double TArea { get; set; }

        // Methods
        public override double Area()
        {
            this.TArea = (this.THeight * this.TBase) / 2.0;
            return this.TArea;
        }
    }
}
