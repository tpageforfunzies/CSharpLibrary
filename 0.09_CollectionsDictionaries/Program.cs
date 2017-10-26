using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //------BRONZE------
            //create a dictionary that has all the academy award winners for best picture
            //from 2000-2005 and iterate over the dictionary and print to console
            Console.WriteLine("------BRONZE------");
            Dictionary<int, string> bronzeMovies = new Dictionary<int, string>();
            bronzeMovies.Add(2000, "Gladiator");
            bronzeMovies.Add(2001, "A Beautiful Mind");
            bronzeMovies.Add(2002, "Chicago");
            bronzeMovies.Add(2003, "Lord of the Rings");
            bronzeMovies.Add(2004, "Milion Dollar Baby");
            bronzeMovies.Add(2005, "Crash");

            foreach (var movie in bronzeMovies)
            {
                Console.WriteLine(movie.Key + ", " + movie.Value);
            }
            Console.WriteLine("");

            //------SILVER------
            //create a dictionary that has Best Picture Nominees from a
            //year that has the year as the key and an array of movies as the values for the same years
            //iterate over that dictionary and print values to the console
            Console.WriteLine("------SILVER------");

            string[] year2k = {"IDK", "Can't Remember"};
            string[] year2k1 = {"Something", "Something Else"};

            Dictionary<int, Array> silverMovies = new Dictionary<int, Array>();

            silverMovies.Add(2000, year2k);
            silverMovies.Add(2001, year2k1);

            foreach (var year in silverMovies)
            { 
                Console.WriteLine(year.Key + ": ");
                foreach (var movie in year.Value)
                {
                    Console.WriteLine(movie);
                }
            }
            Console.WriteLine("");

            //------GOLD------
            //create 2 readline promps first should ask for a year
            //second should ask for a year and list all nominees for the year
            Console.WriteLine("");
            Console.WriteLine("------GOLD------");
            Console.WriteLine("Please type a year between 2000-2005 in the space below to show the movie that won.");
            string movieInput = Console.ReadLine();
            int movieInt = Int32.Parse(movieInput);
            foreach (var movie in bronzeMovies)
            {
                if (movieInt == movie.Key)
                {
                    Console.WriteLine(movie.Value + " won Best Picture that year.");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Please type a year between 2000-2001 to show the movies that were up for an award that year.");
            string movieInput2 = Console.ReadLine();
            int movieInt2 = Int32.Parse(movieInput2);
            foreach (var movie in silverMovies)
            {
                if (movieInt2 == movie.Key)
                {
                    Console.WriteLine("The nominees that year were:");
                    foreach (var film in movie.Value)
                    {
                        Console.WriteLine(film);
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
