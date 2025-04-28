using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class HealingPotion : Potion
    {
        //initialise Healing Potion by using inherited values of itemname and itemdamage
        public HealingPotion(string itemname, int itemamount) : base(itemname, itemamount) { }

        //Writes in the console that the user has picked up this item, and actually adds to inventory
        public virtual void OnCollect(Player player)
        {
            Console.WriteLine($"{player.Name} picked up {itemName}");
            player.PickUpItem(itemName);
        }

        //Explains the effect of using item
        public virtual void Use(Player player, Monster monster)
        {
            Console.WriteLine($"{player.Name} heals by using the {itemName} by {itemAmount} ");
            player.Health+= itemAmount
        }

    }
}
