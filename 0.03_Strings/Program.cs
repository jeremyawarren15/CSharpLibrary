using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string occupation;

            firstname = "Fred";
            lastname = "Rogers";
            occupation = "TV personality";

            string fullName = firstname + " " + lastname;
            Console.WriteLine(fullName);

            Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation + ".");

            // String Interpolation
            Console.WriteLine("Hello, my name is a {0}. I am a {1}.", fullName, occupation);
            Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}");

        }
    }
}
