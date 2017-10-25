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
            Donut jellyDonut = new Donut();

            jellyDonut.Filling = "Cherry Jelly";
            jellyDonut.Price = 7.99m;
            jellyDonut.Type = "Jelly";
            jellyDonut.IsSpecial = true;

            //------BRONZE------
            //Hotel.cs created
            Hotel fancyHotel = new Hotel();

            fancyHotel.RoomNumber = 101;
            fancyHotel.IsAvailable = true;
            fancyHotel.NumBeds = 2;

            //------SILVER------
            //method in hotel.cs
            Console.WriteLine("The room number is " + fancyHotel.PrintRoomNum() + ".");

            //------GOLD------
            //methos in hotel.cs
            Console.WriteLine(fancyHotel.CheckAvail());

        }
    }
}
