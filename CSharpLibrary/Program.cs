using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jeremy", "Warren", 25, 1);
            Student student2 = new Student("Jeremy", "Warren", 1);
            Student student3 = new Student("Jeremy");
        }
    }
}