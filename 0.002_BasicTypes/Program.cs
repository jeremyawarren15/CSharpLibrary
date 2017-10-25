using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._002_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
            int number2 = 5;
            int number3;

            byte myByte = 255;

            char myLetter = 'A';
            string myName = "Jeremy";

            float myFloat = 3.14f;

            double myDouble = 2.54;

            bool myBool = false;

            Console.WriteLine(myName);
            Console.Read();

            // Declaration
            // <type> <variableName> = <optional initializer>;
            int age;
            string country;

            // Initialization
            age = 25;
            Console.WriteLine(age);
            age = 26;
            Console.WriteLine(age);

        }
    }
}
