using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class ListClass : ICollect, IEnum, IList
    {
        public void AddSomeStuff()
        {
            Console.WriteLine("Adding something to the list...");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Checking the capacity of the list...");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking the count of the list...");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the list...");
        }

        public void RemoveSomeStuff()
        {
            Console.WriteLine("Removing something from the list...");
        }
    }
}
