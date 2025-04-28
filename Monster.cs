using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Monster : Creature
	{
        private int monster_damage;
        //A constructor and inheritance has been used to create the Monster object 
        //Monster Class inherits from Creature
        public Monster(string name, int health) : base(name, health) { }

        //Use if statements with the name of the monster and return different damages and different monsters do diff damages
        public int monsterDamage(string monster)
        {
            switch (monster)
            {
                case "Petite porcupine":
                     monster_damage = 5;
                    break;
                case "Dangerous Dragon":
                    monster_damage = 10;
                    break;
                case "Snappy the Crocodile":
                    monster_damage = 13;
                    break;
                case "Dark Knight":
                    monster_damage = 17;
                    break;
                case "Krusty Krab":
                    monster_damage = 20;
                    break;
                case "Ferocious Dog":
                    monster_damage = 22;
                    break;
                case "Tiger Tower":
                    monster_damage = 25;
                    break;
                default:
                    monster_damage = 0;
                    break;



            }
            return monster_damage;
        }

       

    }
   
}

