using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Hotel
    {
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int NumBeds { get; set; }

        public int PrintRoomNum()
        {
            return RoomNumber;
        }

        public string CheckAvail()
        {
            if (IsAvailable)
            {
                return ("Yes (sir or maam) Room " + RoomNumber + " is available.");
            }
            else
            {
                return ("I'm sorry, that room is not available");
            }
        }
    }
}
