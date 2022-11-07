using System;
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

        static string status;

        static int maxlife;

        static int minlife;

        static void Main(string[] args)
        {
            maxhealth = 100;

            minhealth = 0;

            maxshield = 100;

            minshield = 0;

            maxlife = 100;

            minlife = 0;

            health = maxhealth;

            shield = maxshield;

            lives = 3;

            //range checking lives
            if (lives > maxlife)
            {
                lives= maxlife;
            }

            if (lives< minlife)
            {
                lives = minlife;
            }

            ShowHUD();

            Console.WriteLine("Press any key to apply 70 damage");

            Console.ReadKey(true);

            Console.Clear();


            Takedamage(70);

            ShowHUD();

            Console.WriteLine("Press any key to apply 50 damage");

            Console.ReadKey(true);

            Console.Clear();


            Takedamage(50);

            ShowHUD();

            Console.WriteLine("Press any key to heal yourself by 7 points");
            
            Console.ReadKey(true);

            Console.Clear();

            heal(7);

            ShowHUD();

            Console.WriteLine("Press any key to heal your shield by 90 points");

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

            Console.WriteLine("Status: " + status);

            Console.WriteLine("" + "");

            Console.WriteLine("Lives: " + lives);

            Console.WriteLine("-----------");

            Console.WriteLine("" + "");

            //health status'
            if (health == 100)
            {
                status = "Top of your game";
            }

            else if (health >= 90 && health < 100)
            {
                status = "Not even hurt";
            }

            else if (health >= 75 && health < 90)
            {
                status = "Scratched up";
            }

            else if (health >= 50 && health < 75)
            {
                status = "Gushing Blood";
            }

            else if (health >= 25 && health < 50)
            {
                status = "Seeing red";
            }

            else if (health >= 15 && health < 25)
            {
                status = "Life flashing before eyes";
            }

            else if (health > 0 && health < 15)
            {
                status = "Not quite dead";
            }

            else if (health == 0)
            {
                status = "Quite dead";
            }

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

            Console.WriteLine(""+"");

            Console.WriteLine("You took " + dam + " damage!");
        }

        static void heal(int hp)
        {
            health = health + hp;

            //range checking the healing
            if (health < 0)
            {
                health = minhealth;
            }

            if (health > 100)
            {
                health = maxhealth;
            }

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
