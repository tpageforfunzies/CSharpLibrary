﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Player
    {
        //constructor
        public Player(string name)
        {
            Level = 1;
            DodgeChance = 0.1;
            AttackPower = 4;
            Name = name;
            HitPoints = 10;
            Experience = 0;
            CriticalChance = 0.1;
            Defense = 2;
        }

        public int Level { get; set; }
        public double DodgeChance { get; set; }
        public int AttackPower { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Experience { get; set; }
        public double CriticalChance { get; set; }
        public int Defense { get; set; }
        public int DamageOut { get; set; }
        Random rand = new Random();


        public void Stats()
        {
            Console.WriteLine("Your current stats are as follows: ");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"HP: {HitPoints}");
            Console.WriteLine($"Attack: {AttackPower}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Dodge Chance: {DodgeChance.ToString("##%")}");
            Console.WriteLine($"Critical Chance: {CriticalChance.ToString("##%")}");
            Console.WriteLine($"Experience Points: {Experience}\n");
        }

        public void Attack(Enemy enemy)
        {
            Console.WriteLine($"\n{Name} attacks!");

            if (CritCheck())
            {
                Console.WriteLine("Your attack was a critical strike!");
                Console.WriteLine($"You dealt {(AttackPower * 2)} damage!");
                enemy.HitPoints -= (AttackPower * 2);
            }
            else
            {
                Console.WriteLine($"You dealt {AttackPower} damage!");
                enemy.HitPoints -= AttackPower;
            }

            if (enemy.HitPoints > 0)
            {
                Console.WriteLine($"The {enemy.Name} has {enemy.HitPoints} HP left.\n");
            }
            else if (enemy.HitPoints <= 0)
            {
                Console.WriteLine($"You have defeated the {enemy.Name}");
                Console.WriteLine("");
                int itemSpawn = rand.Next(3);
                switch (itemSpawn)
                {
                    case 0:
                        Weapon weapon = new Weapon();
                        weapon.Announce();
                        Console.WriteLine("");
                        weapon.AddStats(this);
                        Stats();
                        break;

                    case 1:
                        Armor armor = new Armor();
                        armor.Announce();
                        Console.WriteLine("");
                        armor.AddStats(this);
                        Stats();
                        break;

                    case 2:
                        Accessory acc = new Accessory();
                        acc.Announce();
                        Console.WriteLine("");
                        acc.AddStats(this);
                        Stats();
                        break;

                    default:
                        break;
                }

            }


        }

        public bool DodgeCheck()
        {
            double dodgeRoll = rand.NextDouble();

            if (dodgeRoll <= DodgeChance)
            {
                return true;
            }

            return false;
        }

        public bool CritCheck()
        {
            double critRoll = rand.NextDouble();

            if (critRoll <= CriticalChance)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            HitPoints = 10;
        }
    }
}
