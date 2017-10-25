using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How are you feeling? ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("That sounds awful.");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("It could be worse.");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Get well Soon!");
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Awesome!");
            }
            else
            {
                Console.WriteLine("Sweet!!!");
            }

            // Verbal Challenge
            Console.Write("How much is in your bank account?");
            int bankAccount = Convert.ToInt32(Console.ReadLine());
            if (bankAccount > 10000)
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Ouch...");
            }
        }
    }
}
