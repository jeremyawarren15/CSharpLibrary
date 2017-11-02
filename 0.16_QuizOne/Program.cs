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
            List<Triangle> shapes = new List<Triangle>
            {
                new Triangle(4, 5),
                new Triangle(3, 5),
                new Triangle(2, 8),
                new Triangle(5, 2),
                new Triangle(2, 3)
            };

            var query = from s in shapes
                        where s.TArea > 4.0
                        orderby s.TArea ascending
                        select s;

            foreach (var shape in query)
            {
                Console.WriteLine(shape.TArea);
            }
        }
    }
}
