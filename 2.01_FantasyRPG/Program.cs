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
            Random rand = new Random();

            Console.WriteLine("Welcome to the worst RPG you've ever played!");
            Console.WriteLine("What is your name, brave warrior?");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);

            Console.WriteLine($"\nWelcome to my world, {player.Name}.");
            player.Stats();

            //adventure loop
            while (true)
            {
                Console.WriteLine("Are you ready to fight a monster? Yes or No to quit");
                string battleReady = Console.ReadLine();
                int mobSpawn = rand.Next(2);
                if (battleReady.ToLower() == "yes")
                {
                    if (mobSpawn == 0)
                    {
                        Bat bat = new Bat();
                        bat.Announce();

                        //battle loop
                        while (bat.HitPoints > 0 && player.HitPoints > 0)
                        {
                            Console.WriteLine("Do you want to attack? Yes or No.");
                            string ready = Console.ReadLine();

                            if (ready.ToLower() != "no" && ready.ToLower() != "yes")
                            {
                                Console.WriteLine("Try that again.");
                            }

                            else if (bat.HitPoints > 0 && ready.ToLower() == "yes")
                            {
                                Console.WriteLine(bat.Art);
                                player.Attack(bat);
                                if (bat.HitPoints > 0)
                                {
                                    if (player.DodgeCheck())
                                    {
                                        Console.WriteLine("You dodged the bat's attack!");
                                    }
                                    bat.Attack(player);
                                }

                            }

                            else if (ready.ToLower() == "no")
                            {
                                Console.WriteLine("Well that's anti-climactic.\n");
                                break;
                            }

                            else
                            {
                                break;
                            }

                        }
                        
                    }
                    else
                    {
                        Ogre ogre = new Ogre();
                        ogre.Announce();

                        //battle loop
                        while (ogre.HitPoints > 0 && player.HitPoints > 0)
                        {
                            Console.WriteLine("Do you want to attack? Yes or No.");
                            string ready = Console.ReadLine();

                            if (ready.ToLower() != "no" && ready.ToLower() != "yes")
                            {
                                Console.WriteLine("Try that again.");
                                ready = Console.ReadLine();
                            }

                            else if (ogre.HitPoints > 0 && ready.ToLower() == "yes")
                            {
                                Console.WriteLine(ogre.Art);
                                player.Attack(ogre);
                                if (ogre.HitPoints > 0)
                                {
                                    if (player.DodgeCheck())
                                    {
                                        Console.WriteLine("You dodged the ogre's attack!");
                                    }
                                    ogre.Attack(player);
                                }

                            }

                            else if (ready.ToLower() == "no")
                            {
                                Console.WriteLine("Well that's anti-climactic.");
                                break;
                            }

                            else
                            {
                                break;
                            }

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
