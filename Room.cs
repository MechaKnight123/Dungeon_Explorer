using System;
using System.Collections.Generic;


namespace DungeonExplorer
{
    public class Room
    {
        public string name;
        private string description;
        private string item;
        private string key;
        public Creature Occupant { get; set;}
        public Item ItemInRoom { get; set; }

        public Room(string description, string item, string name, string key)
        {
            this.description = description;
            this.item = item;
            this.name = name;
            this.key = key;
            
        }

        // Copy constructor- this will be used to change the values of currentRoom
        public Room(Room other)
        {
            description = other.description;
            item = other.item;
            name = other.name;
            key = other.key;
            
        }

        

        //Returns description of the room
        public string GetDescription()
        {
            return description;
        }

        //Return item
        public string GetItem()
        {
            return item;
        }

        //Returns the name of the room
        public string GetName()
        {
            return name;
        }

        //Returns the key of the room
        public string GetKey()
        {
            return key;
        }

        
    }

    
}
