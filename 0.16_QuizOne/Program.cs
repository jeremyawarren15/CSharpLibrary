using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> shapes = new List<Triangle>();
            shapes.Add(new Triangle(4, 5));
            shapes.Add(new Triangle(3, 5));
            shapes.Add(new Triangle(2, 8));
            shapes.Add(new Triangle(5, 2));
            shapes.Add(new Triangle(2, 3));

            foreach (var triangle in shapes)
            {
                Console.WriteLine(triangle.TArea);
            }
        }
    }
}
