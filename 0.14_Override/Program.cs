using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square(3));
            shapes.Add(new Circle(3));
            shapes.Add(new Triangle(4, 5));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
