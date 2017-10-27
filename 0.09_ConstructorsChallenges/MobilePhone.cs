using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsChallenges
{
    class MobilePhone
    {
        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }


        // Methods
        public void PrintDevice()
        {
            Console.WriteLine($"I have a {this.ToString()}.");
        }

        public override string ToString()
        {
            return $"{this.Make} {this.Model}";
        }
    }
}
