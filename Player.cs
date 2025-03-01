using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        public void Players(string name, int health=100) 
        {
            Name = name;
            Health = health;
            Console.WriteLine("Player name is: "+ Name+ " and current health is: "+Health);
        }
        public void PickUpItem(string item)
        {

        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}