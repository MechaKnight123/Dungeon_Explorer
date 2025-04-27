using System;
using System.Media;
using System.Collections.Generic;

namespace DungeonExplorer
{
  
    public abstract class Item: ICollectible
	{
        public string itemName { get; protected set; }
        public int itemAmount { get; protected set; }

        //Constructor
        public Item(string itemname, int itemamount)
        {
            this.itemName = itemname;
            this.itemAmount = itemamount;
        }

        //This is from the ICollectible interface and these void functions will be overrided in each potion and weapon separately as each has a unique function
        public virtual void OnCollect(Player player)
        {
            Console.WriteLine($"{player.Name} picked up {itemName}");
            player.PickUpItem(itemName);
        }

        public virtual void Use(Player player);

    }
}