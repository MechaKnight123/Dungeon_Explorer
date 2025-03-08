using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        public Player(string name, int health=100) 
        {
            Name = name;
            Health = health;
            
        }

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
    }
}