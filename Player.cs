using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace DungeonExplorer
{
    class Player: Creature
    {
        
        private List<string> inventory = new List<string>();

        //A constructor and inheritance has been used to create the Player object 
        // Player Class inherits from Creature
        public Player(string name, int health): base(name, health) { } 
        

        // Method adds item to the inventory
        public void PickUpItem(string item)
        {
            inventory.Add(item);
        }

        //Joins items in the inventory together
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }

        //Checks if item already exists in the inventory
        public bool DoesItemExist(string item)
        {
            return inventory.Any(x => x.Equals(item, StringComparison.OrdinalIgnoreCase));
        }

        //Player loses health when attacked
        public override void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} loses {amount} of health and current health is: {Health}");
        }

        //When a player attacks, the Monster of that room takes damage, through the TakeDamage function in the Monster file
        //Damage taken by Monster varies on the item used by player- hence Monster object and item_damage are passed into function
        public override void Attack(IDamageable target,int item_damage)
        {
            if (target is Monster monster)
            {
                monster.TakeDamage(item_damage);
            }
            else
            {
                Console.WriteLine("There is nothing to attack here");
            }
        
        }


    }
}