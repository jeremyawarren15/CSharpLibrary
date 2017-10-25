using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 10; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("End of the loop");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Bronze Challenge
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Silver Challenge
            for (int i = 0; i <= 100; i+=5)
            {
                Console.WriteLine(i);
            }

            // Gold Challenge
            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
            // Project Euler Challenge
            int a = 0, b = 1, c = 0;
            int sum = 0;

            while (c <= 4000000)
            {
                c = a + b;
                if (c % 2 == 0)
                {
                    sum += c;
                }
                a = b;
                b = c;
            }
            Console.WriteLine(sum);
        }
    }
}
