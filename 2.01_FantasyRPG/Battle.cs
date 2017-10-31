using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Battle
    {
        public Battle(Enemy enemy, Player player)
        {
            this.Player = player;
            this.Enemy = enemy;
        }

        public void Fight()
        {
            while (Enemy.HitPoints > 0 && Enemy.HitPoints > 0)
            {
                Console.WriteLine("Do you want to attack? Yes or No.");
                string ready = Console.ReadLine();

                if (ready.ToLower() != "no" && ready.ToLower() != "yes")
                {
                    Console.WriteLine("Try that again.");
                }

                else if (Enemy.HitPoints > 0 && ready.ToLower() == "yes")
                {
                    Console.Clear();
                    Console.WriteLine(Enemy.Art);
                    Player.Attack(Enemy);
                    if (Enemy.HitPoints > 0 && !Player.DodgeCheck())
                    {
                        Enemy.Attack(Player);
                    }
                    else if (Player.DodgeCheck())
                    {
                        Console.WriteLine("You dodged the bat's attack!");
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
            if (Player.HitPoints <= 0)
            {
                Player.Reset();
            }
        }

        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
    }
}
