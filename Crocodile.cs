using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Crocodile : Monster
    {
        public Crocodile(string name, int health) : base(name, health) { }


        //Monster loses Health when attacked by player
        public override void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} loses {amount} of health and current health: {Health}");
        }

        //Player object and monster_damage are passed into function because when the monster attacks, Player.Health decreases
        //monster_damage varies on the Monster in the Room
        public override void Attack(IDamageable target, int monster_damage)
        {
            if (target is Player player)
            {
                Console.WriteLine($"{Name} takes a massive bite on you ");
                target.TakeDamage(monster_damage);
            }
        }



    }
}
