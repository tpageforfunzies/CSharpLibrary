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

            //------BRONZE------
            //Hotel.cs created
            Hotel fancyHotel = new Hotel();

            fancyHotel.RoomNumber = 101;
            fancyHotel.IsAvailable = true;
            fancyHotel.NumBeds = 2;

            //------SILVER------
            //method in hotel.cs
            Console.WriteLine("The room number is " + fancyHotel.PrintRoomNum() + ".");
            Console.WriteLine("");

            //------GOLD------
            //methos in hotel.cs
            Console.WriteLine(fancyHotel.CheckAvail());
            Console.WriteLine("");


            //------BRONZE2------
            //Create a netflix class with properties Name, Genre, Rating
            //Create three objects from that class

            Netflix southPark = new Netflix();
            southPark.Rating = 4;
            southPark.Genre = "Comedy";
            southPark.Name = "South Park";

            Netflix theOffice = new Netflix();
            theOffice.Rating = 5;
            theOffice.Genre = "Comedy";
            theOffice.Name = "The Office";

            Netflix bigBangTheory = new Netflix();
            bigBangTheory.Rating = 1;
            bigBangTheory.Genre = "Comedy";
            bigBangTheory.Name = "Big Bang Theory";


            //------SILVER2------
            //create a method called GetSuggestion() that returns different messages if the rating is over 4
            //and an else statement

            Console.WriteLine("South Park: " + southPark.GetSuggestion());
            Console.WriteLine("");
            Console.WriteLine("Big Bang Theory: " + bigBangTheory.GetSuggestion());
            Console.WriteLine("");


            //------GOLD2------
            //create a list of objects based on the netflix class
            //foreach loop through the list and print the name,
            //genre, and rating of each object

            List<Netflix> shows = new List<Netflix>();
            shows.Add(southPark);
            shows.Add(theOffice);
            shows.Add(bigBangTheory);

            foreach (Netflix show in shows)
            {
                Console.WriteLine("Name: " + show.Name);
                Console.WriteLine("Genre: " + show.Genre);
                Console.WriteLine("Rating: " + show.Rating);
                Console.WriteLine("");
            }



        }
    }
}
