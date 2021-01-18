using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem_2._0
{
    class Player
    {
        static int health = 100;
        static int shield = 100;
        static int lives = 3;

        public static void TakeDamage(int damage)
        {
            Console.WriteLine("\nYou have taken " + damage + " points of damage.\n");

            int healthDamage;
            healthDamage = damage - shield;

            shield -= damage;

            if (shield <= 0)
            {
                shield = 0;
                health -= healthDamage;
            }

            if (health <= 0)
            {
                Console.WriteLine("\nYou lost a life!\n");
                lives--;
                health = 100;
                shield = 100;
            }
            if (lives <= 0)
            {
                lives = 0;
                health = 0;
                Console.WriteLine("\n\nYou Have Died\n");
            }
        }

        public static void Heal(int hp)
        {
            if(health < 100)
            {
                Console.WriteLine("\nYou have healed " + hp + " points.\n");
                health += hp;
            }
            if (health > 100) health = 100;
        }

        public static void ShowStats()
        {
            Console.WriteLine("|Shield: " + Player.shield);
            Console.WriteLine("|Health: " + Player.health);
            Console.WriteLine("|Lives: " + Player.lives);
        }

        public static void RegenerateShield(int shieldPoints)
        {
            if (shield < 100)
            {
                Console.WriteLine("\nYou have regenerated " + shieldPoints + " points to your Shield.\n");
                shield += shieldPoints;
            }
            if (shield > 100) shield = 100;
        }
    }
}
