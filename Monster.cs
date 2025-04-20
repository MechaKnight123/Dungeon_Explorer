using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Monster : Creature
    {
        //A constructor and inheritance has been used to create the Monster object 
        //Monster Class inherits from Creature
        public Monster(string name, int health) : base(name, health) { }


    }
}

