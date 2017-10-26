using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix theOffice = new Netflix();
            Netflix strangerThings = new Netflix();
            Netflix lost = new Netflix();

            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 3;

            strangerThings.Name = "Stranger Things";
            strangerThings.Genre = "Thriller";
            strangerThings.Rating = 5;

            lost.Name = "Lost";
            lost.Genre = "Thriller";
            lost.Rating = 4;

            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(theOffice);
            favoriteShows.Add(strangerThings);
            favoriteShows.Add(lost);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine(show.Name);
            }
        }
    }
}
