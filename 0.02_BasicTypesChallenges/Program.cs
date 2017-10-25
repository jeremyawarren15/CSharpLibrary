using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challenge
            int myInt = 1;
            string myString;
            bool myBool = true;
            float myFloat = 3.14f;
            double myDouble = 9.23423;
            decimal myDecimal = 1234123.234m;

            // Silver Challenge
            myString = $"{myInt} {myBool} {myFloat} {myDouble} {myDecimal}";
            Console.WriteLine(myString);

            // Gold Challenge
            string year = "1991";
            int myBirthYear = Convert.ToInt32(year);
            Console.WriteLine($"I was born in {myBirthYear}");
            Console.Read();
        }
    }
}
