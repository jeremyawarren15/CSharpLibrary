using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOPGame
{
    public abstract class Character
    {
        // Constants
        const int Min_Helth = 0;

        // Properties
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackLevel { get; set; }
        public int Stamina { get; set; }
        public int Luck { get; set; }
        
        public void GetPowerLevel()
        {
            Random rnd = new Random();
            this.Level =  rnd.Next(1, 100);
        }

        public int Attack(int attackLevel)
        {
            Random rnd = new Random();
            return rnd.Next(1, attackLevel);
        }
    }
}
