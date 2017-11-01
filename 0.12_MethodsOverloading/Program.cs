using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Player class with
            // 1 Attack() methods that acccepts 3 different sets of parameters
            Player p = new Player();
            p.Attack(1000);
            p.Attack(1000, "dusty stick");
            p.Attack(5, "axe", 30);
        }
    }
}
