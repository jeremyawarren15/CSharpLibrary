using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class ArrayClass : IEnum, IList, ICollect
    {
        public void AddSomeStuff()
        {
            Console.WriteLine("Add stuff to the array");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("You can't check the capacity of an array...");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking the count of the array...");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the array...");
        }

        public void RemoveSomeStuff()
        {
            Console.WriteLine("Remove stuff from the array");
        }
    }
}
