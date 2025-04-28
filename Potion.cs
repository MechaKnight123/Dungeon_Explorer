using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
	class Potion : Item
	{
		//Constructor
		//Inheritance is used to get values that will be needed to initialise the Potion object
		public Potion(string itemname, int itemamount) : base(itemname, itemamount) { }
	
		
	}
}
