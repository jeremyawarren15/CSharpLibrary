using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newHero = new Player();

            Console.Write("Greetings, wayfarer! What be thy name? ");
            newHero.Name = Console.ReadLine();

            Console.Clear();
            Console.Write($"Nice to meet you, {newHero.Name}.\n");

            Console.Write($"What's your specialization frield?" +
                $"1: Horse Mange\n" +
                $"2: Troll Cat\n" +
                $"3: Knight Templatetor\n" +
                $"4: Demogorg\n" +
                $"5: Sire Cena\n" +
                $"Your choice: ");
        }
    }
}
