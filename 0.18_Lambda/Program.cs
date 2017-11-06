using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> myFunc = x => x == 5;
            bool result = myFunc(4);
            Console.WriteLine(result);

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine(oddNumbers);


        }
    }
}
