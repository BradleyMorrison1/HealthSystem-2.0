using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem_2._0
{
    class Player
    {
         int health;
         int shield;
         int lives;

        public Player()
        {
            health = 100;
            shield = 100;
            lives = 3;
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine("\nYou have taken " + damage + " points of damage.\n");

            int healthDamage = damage - shield;

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

        public void Heal(int hp)
        {
            if(health < 100)
            {
                Console.WriteLine("\nYou have healed " + hp + " points.\n");
                health += hp;
            }
            if (health > 100) health = 100;
        }

        public void ShowStats()
        {
            Console.WriteLine("|Shield: " + shield);
            Console.WriteLine("|Health: " + health);
            Console.WriteLine("|Lives: " + lives);
        }

        public void RegenerateShield(int shieldPoints)
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
