using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage}!");
        }

        public void Attack(int damage, string weapon, int numberOfTimes)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage} {numberOfTimes} times, dealing {numberOfTimes * damage}!");
        }
    }
}
