using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut KennDonut = new Donut();
            Donut PaulDonut = new Donut();
            Donut JeremyDonut = new Donut();

            KennDonut.Filling = "Strawberry Jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

            PaulDonut.Filling = "Cherry Jelly";
            PaulDonut.Price = 7.99m;
            PaulDonut.Type = "Jelly";
            PaulDonut.IsSpecial = true;

            JeremyDonut.Filling = "None";
            JeremyDonut.Price = 1;
            JeremyDonut.Type = "Glazed";
            JeremyDonut.IsSpecial = true;

            Console.WriteLine(PaulDonut);
            Console.WriteLine(PaulDonut.Filling);
        }
    }
}
