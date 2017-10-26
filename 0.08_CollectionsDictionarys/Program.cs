using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsDictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze
            Dictionary<int, string> academyAwards = new Dictionary<int, string>();
            academyAwards.Add(2000, "American Beauty");
            academyAwards.Add(2001, "Gladiator");
            academyAwards.Add(2002, "Beautiful Mind");
            academyAwards.Add(2003, "Chicago");
            academyAwards.Add(2004, "Lord of the Rings: The Return of the King");
            academyAwards.Add(2005, "Million Dollar Baby");

            foreach (var movie in academyAwards)
            {
                Console.WriteLine($"{movie.Key} {movie.Value}");
            }

            // Silver
            Dictionary<int, string[]> bestPictureNominees = new Dictionary<int, string[]>();
            bestPictureNominees.Add(2017, new string[] {"Arrival", "Fences", "Hacksaw Ridge", "Hell or High Water"});
            bestPictureNominees.Add(2016, new string[] { "The Big Short", "Bridge of Spies", "Brooklyn", "Mad Max: Fury Road"});

            foreach (var year in bestPictureNominees)
            {
                Console.Write($"{year.Key} ");
                foreach (var movie in year.Value)
                {
                    Console.Write(movie + ", ");
                }
                Console.Write("\n");
            }

        }
    }
}
