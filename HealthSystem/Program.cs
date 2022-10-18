﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {
        static int health;

        static int shield;

        static int lives;

        static int minhealth;

        static int maxhealth;

        static int maxshield;

        static int minshield;

        static string hstatus;

        static void Main(string[] args)
        {
            maxhealth = 100;

            minhealth = 0;

            maxshield = 50;

            minshield = 0;

            health = 100;

            shield = 50;

            lives = 3;

            ShowHUD();

            Console.WriteLine("Press any key to apply 30 damage");

            Console.ReadKey(true);

            Console.Clear();


            Takedamage(30);

            ShowHUD();

            Console.WriteLine("Press any key to apply 40 damage");

            Console.ReadKey(true);

            Console.Clear();


            Takedamage(40);

            ShowHUD();

            Console.WriteLine("Press any key to heal yourself by 7 points");
            
            Console.ReadKey(true);

            Console.Clear();

            heal(7);

            ShowHUD();

            Console.WriteLine("Press any key to heal your shield by 50 points");

            Console.ReadKey(true);

            Console.Clear();

            regenshield(100);

            ShowHUD();

            Console.WriteLine("Press any key to do a whole lot of damage");

            Console.ReadKey(true);

            Console.Clear();

            Takedamage(1000);

            ShowHUD();

            Console.ReadKey(true);

        }

        static void ShowHUD()
        {
            Console.WriteLine("" + "");

            Console.WriteLine("-----------");

            Console.WriteLine("Shield: " + shield);
            
            Console.WriteLine("" + "");

            Console.WriteLine("Health: " + health);

            Console.WriteLine("" + "");

            Console.WriteLine("Status: " + hstatus);

            Console.WriteLine("" + "");

            Console.WriteLine("Lives: " + lives);

            Console.WriteLine("-----------");

            Console.WriteLine("" + "");
        }

        static void Takedamage(int dam)
        {
            int mindam = 0;//the least amount of damage that can be done

            int dam2;//damage done after shield is damaged

            dam2 = dam - shield;

            shield = shield - dam;



            //range checking damaged done to health
            if (dam2 < mindam)
            {
                dam2 = mindam;
            }

            //range checking hp
            if (dam < mindam)
            {
                dam = mindam;
            }

            health = health - dam2; //health being damaged

            //range checking shield
            if (shield > maxshield)
            {
                shield = maxshield;
            }

            if (shield < minshield)
            {
                shield = minshield;
            }


            //range checking health
            if(health < minhealth)
            {
                health = minhealth;
            }

            if (health > maxhealth)
            {
                health = maxhealth;
            }

            //taking away a life
            if (health <= minhealth)
            {
                lives = lives - 1;
                
                health = maxhealth;
            }

            Console.WriteLine("You took " + dam + " damage!");
        }

        static void heal(int hp)
        {
            if (health < 0)
            {
                health = minhealth;
            }

            if (health > 100)
            {
                health = maxhealth;
            }

            health = health + hp;

        }

        static void regenshield(int regen)
        {
            shield=shield + regen;

            //range checking shield
            if (shield > maxshield)
            {
                shield=maxshield;
            }

            if(shield < minshield)
            {
                shield=minshield;
            }
        }

    }
}