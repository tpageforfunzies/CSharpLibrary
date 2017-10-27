using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //------BRONZE------
            //Create a MobilePhone class for moblie devices. Have two properties: Make and Model.
            //Using that constructor, create a new phone object that tells what kind of phone you have, and print to the console

            MobilePhone myPhone = new MobilePhone("Taylor", "iPhone", "Six");
            Console.WriteLine(myPhone.Explain());
            Console.WriteLine("");

            //------SILVER------
            //Print a list of five friends and what they own. 
            //Laurissa has an iPhone 6. Ava has the iPhone 5. Kenn has the Samsung Galaxy. Etc...

            MobilePhone keithPhone = new MobilePhone("Keith", "Google", "Pixel");
            MobilePhone momPhone = new MobilePhone("Mom", "iPhone", "Seven+");
            MobilePhone dadPhone = new MobilePhone("Dad", "iPhone", "Seven+");
            MobilePhone mattPhone = new MobilePhone("Matt", "Samsung", "Note");
            MobilePhone meganPhone = new MobilePhone("Megan", "Samsung", "S7");

            List<MobilePhone> myFriends = new List<MobilePhone>();
            myFriends.Add(keithPhone);
            myFriends.Add(momPhone);
            myFriends.Add(dadPhone);
            myFriends.Add(mattPhone);
            myFriends.Add(meganPhone);

            foreach (var friend in myFriends)
            {
                Console.WriteLine(friend.Explain());
            }
            Console.WriteLine("");

        }
    }
}
