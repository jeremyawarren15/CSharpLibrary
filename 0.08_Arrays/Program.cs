using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challnge
            string[] food = new string[] { "Apple", "Orange", "Pizza" };
            foreach (string f in food)
            {
                Console.WriteLine(f);
            }

            // Silver Challenge
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            int[] y = new int[] { 6, 7, 8, 9, 10 };
            int[] sums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                sums[i] = x[i] + y[i];
            }

            foreach (var num in sums)
            {
                Console.WriteLine(num);
            }

            // Gold Challenge
            int[] numbers = new int[10];
            Random rnd = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next();
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
