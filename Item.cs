using System;
using System.Media;
using System.Collections.Generic;

namespace DungeonExplorer
{
  
    public abstract class Item
	{
        public string itemName { get; protected set; }
        public int itemDamage { get; protected set; }

        //Constructor
        public Item(string itemname, int itemdamage)
        {
            this.itemName = itemname;
            this.itemDamage = itemdamage;
        }


    }
}