using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public void GetSuggestion()
        {
            if (Rating >= 4)
            {
                Console.WriteLine("I would watch this movie.");
            }
            else
            {
                Console.WriteLine("I wouldn't watch this movie.");
            }
        }
    }
}
