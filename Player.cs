using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonExplorer
{
    public class Player: Creature
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
    }
}