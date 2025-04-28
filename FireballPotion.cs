using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class FireballPotion : Potion
    {
        //initialise Fireball Potion by using inherited values of itemname and itemdamage
        public FireballPotion(string itemname, int itemamount) : base(itemname, itemamount) { }

        //Writes in the console that the user has picked up this item, and actually adds to inventory
        public override void OnCollect(Player player)
        {
            Console.WriteLine($"{player.Name} picked up {itemName}");
            player.PickUpItem(itemName);
        }

        //Explains the effect of using item
        public override void Use(Player player, Monster monster)
        {
            Console.WriteLine($"{player.Name} chucks the {itemName} and causes {itemAmount} damage!");
            player.Attack(monster, itemAmount);
        }

    }
}
