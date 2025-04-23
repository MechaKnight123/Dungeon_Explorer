using System;
using System.Media;
using System.Collections.Generic;

namespace DungeonExplorer
{ 
    //abstract class inherits from interface IDamageable
	public abstract class Creature: IDamageable
	{
        public string Name { get; private set; }
        public int Health { get; protected set; }

        //Constructor
        public Creature(string name, int health = 100)
		{
            Name = name;
            Health = health;
		}

        // Base methods/ functions from IDamageable - will be overrided in Monster and Player files
        public virtual void TakeDamage(int amount) 
        {
            Health -= amount;
            Console.WriteLine($"{Name} loses {amount} of health and current health: {Health}");
        }

        public virtual void Attack(IDamageable target,int damage)
        {
            Console.WriteLine("Default");
        }

    }
}