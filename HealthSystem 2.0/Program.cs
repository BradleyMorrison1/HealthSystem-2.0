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

            Player.ShowStats();

            Player.TakeDamage(155);
            Player.ShowStats();
            Player.RegenerateShield(66);
            Player.ShowStats();
            Player.TakeDamage(70);
            Player.ShowStats();
            Player.Heal(66);
            Player.ShowStats();
            Player.Heal(200);
            Player.ShowStats();
            Player.RegenerateShield(200);
            Player.ShowStats();
            Player.TakeDamage(1000);
            Player.ShowStats();

            Console.ReadKey(true);
        }
    }
}
