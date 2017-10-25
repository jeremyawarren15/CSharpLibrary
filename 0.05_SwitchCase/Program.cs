using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Jeremy";

            switch (friend)
            {
                case "Jeremy":
                    Console.WriteLine("Hey Jeremy");
                    break;
                case "Paul":
                    Console.WriteLine("Paul is pretty cool");
                    break;
                default:
                    Console.WriteLine("I don't know you");
                    break;
            }
        }
    }
}
