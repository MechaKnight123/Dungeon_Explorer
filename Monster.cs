using System;

namespace DungeonExplorer
{
	public class Monster: Creature
	{
		//A constructor and inheritance has been used to create the Monster object 
		//Monster Class inherits from Creature
		public Monster(string name, int health): base(name,health) { }
	
		
	}
}