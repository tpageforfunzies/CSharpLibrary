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
                Console.WriteLine("Are you ready to fight a monster? Yes or No");
                string battleReady = Console.ReadLine();
                int mobSpawn = rand.Next(2);
                if (battleReady.ToLower() == "yes")
                {
                    if (mobSpawn == 0)
                    {
                        Bat bat = new Bat();
                        Console.WriteLine(bat.Art);
                        bat.Announce();

                        //battle loop
                        while (bat.HitPoints > 0 || player.HitPoints > 0)
                        {
                            player.Attack();
                            bat.HitPoints -= player.DamageOut;
                            if (bat.HitPoints <= 0)
                            {
                                Console.WriteLine("You defeated the bat!\n");
                                break;
                            }
                            Console.WriteLine($"The bat has {bat.HitPoints} HP left.\n");
                            bat.Attack();
                            player.HitPoints -= (bat.DamageOut - player.Defense);
                            Console.WriteLine($"{player.Name} has {player.HitPoints} HP left.\n");
                        }
                        
                    }
                    else
                    {
                        Ogre ogre = new Ogre();
                        Console.WriteLine(ogre.Art);
                        ogre.Announce();

                        //battle loop
                        while (ogre.HitPoints > 0 || player.HitPoints > 0)
                        {
                            player.Attack();
                            ogre.HitPoints -= player.DamageOut;
                            if (ogre.HitPoints <= 0)
                            {
                                Console.WriteLine("You defeated the ogre!\n");
                                break;
                            }
                            Console.WriteLine($"The ogre has {ogre.HitPoints} HP left.\n");
                            ogre.Attack();
                            player.HitPoints -= (ogre.DamageOut - player.Defense);
                            Console.WriteLine($"{player.Name} has {player.HitPoints} HP left.\n");
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
