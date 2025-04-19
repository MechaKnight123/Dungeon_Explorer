using System;

namespace DungeonExplorer
{
	public abstract class Creature
	{
        public string Name { get; private set; }
        public int Health { get; private set; }

        //Constructor
        public Creature(string name, int health=100)
		{
            Name = name;
            Health = health;
        }
	}
}