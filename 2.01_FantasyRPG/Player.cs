﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_FantasyRPG
{
    class Player
    {
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
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine($"HP: {this.HitPoints}");
            Console.WriteLine($"Attack: {this.AttackPower}");
            Console.WriteLine($"Defense: {this.Defense}");
            Console.WriteLine($"Dodge Chance: {this.DodgeChance.ToString("##%")}");
            Console.WriteLine($"Critical Chance: {this.CriticalChance.ToString("##%")}");
            Console.WriteLine($"Experience Points: {this.Experience}\n");
        }

        public void Attack()
        {
            double critRoll = rand.NextDouble();
            double dodgeRoll = rand.NextDouble();
            Console.WriteLine($"{Name} attacks!");

            if (critRoll <= CriticalChance)
            {
                Console.WriteLine("Your attack was a critical strike!");
                Console.WriteLine($"You dealt {(AttackPower * 2)} damage!\n");
                DamageOut = (AttackPower * 2);


            }
            else
            {
                Console.WriteLine($"You dealt {this.AttackPower} damage!\n");
                DamageOut = AttackPower;
            }
        }
    }
}