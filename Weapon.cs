using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
	public abstract class Weapon : Item
	{
		//Constructor
		//Inheritance is used to create/ initialise a weapon object
		public Weapon(string itemname, int itemamount) : base(itemname, itemamount) { }
		
	}

}