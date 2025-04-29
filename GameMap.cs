using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
	public class GameMap
	{
        
        private Room Room1, Room2, Room3, Room4, Room5, Room6, Room7;
        private List<Room> rooms = new List<Room>();
        public Room CurrentRoom { get; private set; }

        public GameMap()
		{
            SetupRooms();
        }
		private void SetupRooms()
		{

            // Initialize the game with 5 rooms with a description, item, name,key and a monster- there is a current room to indicate the room the user is in
            //User starts the Game in Precious patio room    
            Room1 = new Room("This is the Precious Patio where unique things happen", "Welcome Mat", "Precious Patio", "Room1 key");
            Room2 = new Room("This is the Dragon's dungeon where there have been many fallen soldiers", "Diamond Sword", "Dragon's dungeon", "Room2 key");
            Room3 = new Room("This is the Snappy Crocodile's swamp where things happen unexpectedly quick", "Poison Potion", "Snappy swamp", "Room3 key");
            Room4 = new Room("This is the Dark Knight's domain and not many who visit this place are able to tell the tale", "Fireball potion", "Dark Knight's potion", "Room4 key");
            Room5 = new Room("This is Krusty Krab's lagoon where there is a strange and mysterious creature", "Healing potion", "Krusty Krab's Lagoon", "Room5 key");
            Room6 = new Room("This is Pleasant Park where there is an ominous and ferocious dog", "Leafblower", "Pleasant Park", "Room6 key");
            Room7 = new Room("This is Tilted Towers where the buildings are all shaped peculiarly", "Canon", "Tilted Towers", "Room7 key");

            //Every room has a Monster with a unique name and health and even effects
            Room1.Occupant = new Porcupine("Petite porcupine", 25);
            Room2.Occupant = new Dragon("Dangerous Dragon", 30);
            Room3.Occupant = new Crocodile("Snappy the Crocodile", 35);
            Room4.Occupant = new Knight("Dark Knight", 40);
            Room5.Occupant = new Crab("Krusty Krab", 45);
            Room6.Occupant = new Dog("Ferocious Dog", 50);
            Room7.Occupant = new Tower("Tiger Tower", 55);

            //Every room has a Item with itemName and itemAmount and will either be a Potion or Weapon
            Room1.ItemInRoom = new WelcomeMat("Welcome Mat", 30);
            Room2.ItemInRoom = new DiamondSword("Diamond Sword", 50);
            Room3.ItemInRoom = new PoisonPotion("Poison Potion", 35);
            Room4.ItemInRoom = new FireballPotion("Fireball potion", 40);
            Room5.ItemInRoom = new HealingPotion("Healing potion", 100);
            Room6.ItemInRoom = new LeafBlower("Leafblower", 10);
            Room7.ItemInRoom = new Canon("Canon", 55);

            CurrentRoom = Room1;
        }
    }

}