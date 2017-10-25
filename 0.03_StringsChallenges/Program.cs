using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challenge

            // Prints the current hour using composite formatting
            // {index,alignment:format}
            Console.WriteLine("{0:hh}", DateTime.Now);

            Console.WriteLine("{0} {1}", 1, 2);

            // Prints with two columns
            string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                         "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                 16.75m };

            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
            {
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);
            }

            // Currency
            double cash = 563.3265;
            Console.WriteLine($"{cash:C}");

            // Percentage
            double exchangeRate = 0.25;
            Console.WriteLine($"{exchangeRate:#0.##%}");
            Console.WriteLine($"{exchangeRate:P}");

            // Phone Number
            long phoneNumber = 3173066750;
            Console.WriteLine($"{phoneNumber:(###) ###-####}");

            // Silver Challenge
            string potentialEmployerName = "John Smith";
            Console.WriteLine($"Hello {potentialEmployerName},");
            Console.WriteLine(
                $"Today is {DateTime.Now:d}. I'm enjoying class, and I think I like C# the best.\n" +
                $"I'd like to get a job as a developer when I am done with this course."
                );

            // Gold Challenge
            string upUserName = "JEREMYAWARREN15";
            string lowUserName = "jeremyawarren15";
            bool result1 = upUserName.Equals(lowUserName, StringComparison.Ordinal); // should be not equal
            Console.WriteLine($"{upUserName} and {lowUserName} are {(result1 ? "equal." : "not eqaul.")}"); 
            bool result2 = upUserName.Equals(lowUserName, StringComparison.OrdinalIgnoreCase); // should be equal
            Console.WriteLine($"{upUserName} and {lowUserName} are {(result2 ? "equal." : "not eqaul.")}");
        }
    }
}
