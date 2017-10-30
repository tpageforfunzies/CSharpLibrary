using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            Random rand = new Random();

            Console.WriteLine("Welcome to the worst RPG you've ever played!");
            Console.WriteLine("What is your name, brave warrior?");
            playerName = Console.ReadLine();

            Player Player = new Player(playerName);

            Console.WriteLine($"\nWelcome to the world, {Player.Name}.");
            Player.Stats();

            //adventure loop
            while (true)
            {
                Console.WriteLine("Are you ready to fight a monster? Yes or No");
                string battleReady = Console.ReadLine();
                int mobSpawn = rand.Next(2);
                if (battleReady.ToLower() == "yes")
                {
                    if (mobSpawn == 0)
                    {
                        Bat Bat = new Bat();
                        Console.WriteLine(Bat.Art);
                        Bat.Announce();

                        //battle loop
                        while (Bat.HitPoints > 0 || Player.HitPoints > 0)
                        {
                            Player.Attack();
                            Bat.HitPoints -= Player.DamageOut;
                            if (Bat.HitPoints <= 0)
                            {
                                Console.WriteLine("You defeated the bat!\n");
                                break;
                            }
                            Console.WriteLine($"The bat has {Bat.HitPoints} HP left.\n");
                            Bat.Attack();
                            Player.HitPoints -= Bat.DamageOut;
                            Console.WriteLine($"{Player.Name} has {Player.HitPoints} HP left.\n");
                        }
                        
                    }
                    else
                    {
                        Ogre Ogre = new Ogre();
                        Console.WriteLine(Ogre.Art);
                        Ogre.Announce();

                        //battle loop
                        while (Ogre.HitPoints > 0 || Player.HitPoints > 0)
                        {
                            Player.Attack();
                            Ogre.HitPoints -= Player.DamageOut;
                            if (Ogre.HitPoints <= 0)
                            {
                                Console.WriteLine("You defeated the ogre!\n");
                                break;
                            }
                            Console.WriteLine($"The ogre has {Ogre.HitPoints} HP left.\n");
                            Ogre.Attack();
                            Player.HitPoints -= Ogre.DamageOut;
                            Console.WriteLine($"{Player.Name} has {Player.HitPoints} HP left.\n");
                        }
                    }

                }
                else
                {
                    break;
                }
            }
        }
    }
}
