using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System 2.0 | Bradley Morrison\n\n");
            Player player = new Player();

            player.ShowStats();
            player.TakeDamage(155);
            player.ShowStats();
            player.RegenerateShield(66);
            player.ShowStats();
            player.TakeDamage(70);
            player.ShowStats();
            player.Heal(66);
            player.ShowStats();
            player.Heal(200);
            player.ShowStats();
            player.RegenerateShield(200);
            player.ShowStats();
            player.TakeDamage(1000);
            player.ShowStats();

            Console.ReadKey(true);
        }
    }
}
