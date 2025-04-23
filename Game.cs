using System;
using System.Media;
using System.Collections.Generic;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Room Room1, Room2, Room3, Room4, Room5,Room6,Room7;
        public List<string> roomList = new List<string>();

        public Game()
        {
            // Initialize the game with 5 rooms with a description, item, name,key and a monster- there is a current room to indicate the room the user is in
            //User starts the Game in Precious patio room
            currentRoom = new Room("This is the Precious Patio where unique things happen", "Welcome Mat", "Precious Patio","Room1 key","Petite porcupine");
            Room1 = new Room("This is the Precious Patio where unique things happen", "Welcome Mat", "Precious Patio", "Room1 key", "Petite porcupine");
            Room2 = new Room("This is the Dragon's dungeon where there have been many fallen soldiers", "Diamond Sword", "Dragon's dungeon", "Room2 key","Dragon");
            Room3 = new Room("This is the Snappy Crocodile's swamp where things happen unexpectedly quick", "Poison Potion", "Snappy swamp", "Room3 key","Snappy the Crocodile");
            Room4 = new Room("This is the Dark Knight's domain and not many who visit this place are able to tell the tale", "Fireball potion", "Dark Knight's potion", "Room4 key","Dark Knight");
            Room5 = new Room("This is Krusty Krab's lagoon where there is a strange and mysterious creature", "Healing potion", "Krusty Krab's Lagoon", "Room5 key","Krusty Krab");
            Room6 = new Room("This is Pleasant Park where there is an ominous and ferocious dog", "Leafblower", "Pleasant Park", "Room6 key","Ferocious Dog");
            Room7 = new Room("This is Tilted Towers where the buildings are all shaped peculiarly", "Canon", "Tilted Towers", "Room7 key","Tiger Tower");

            //Created a list containing the names of the rooms in the game
            roomList.Add(Room1.GetName());
            roomList.Add(Room2.GetName());
            roomList.Add(Room3.GetName());
            roomList.Add(Room4.GetName());
            roomList.Add(Room5.GetName());
            roomList.Add(Room6.GetName());
            roomList.Add(Room7.GetName());
        }
        public void Start()
        {
            bool playing = false;
            Console.WriteLine("Are you ready to start? Enter y/n"); //Asks the user if they want to start the game
            string input = Console.ReadLine();
            if (!string.Equals("y", input, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            playing = true;
            Console.Write("Enter your name: ");
            string playersName = Console.ReadLine();
            player = new Player(playersName,100); // Player object has been created with name inputted by user and health set to 100

            while (playing)
            {
                //Asks user to enter 1, 2, 3 or 4
                string initialIntro = "Enter 1 to add an item, 2. to view room's description, 3. to get current items and health and 4. to exit the program";
               
                //An intro message to the game is displayed and users input is store in the variable nextStep 
                Console.WriteLine($"\nHey {playersName}. Welcome to the dungeons! \n{initialIntro}");
                string nextStep = Console.ReadLine();
                
                //The value entered by the user will determine the next steps the program takes
                if (string.Equals("1", nextStep, StringComparison.OrdinalIgnoreCase))
                {
                    PickUpItem(); // Adds item to inventory when 1 is inputted
                }
                else if (string.Equals("2", nextStep, StringComparison.OrdinalIgnoreCase))
                {   
                    // Displays rooms decription if user enters 2
                    Console.WriteLine($"Current room's description is: {currentRoom.GetDescription()}");
                }
                else if (string.Equals("3", nextStep, StringComparison.OrdinalIgnoreCase))
                {
                    //Displays inventory and health when user enters 3
                    Console.WriteLine($"You have these items: {player.InventoryContents()}. \nYour health is: {player.Health}");
                    if (player.InventoryContents() == "")
                    {
                        Console.WriteLine("You currently have no items in your inventory");
                    }
                }
                else if (string.Equals("4", nextStep, StringComparison.OrdinalIgnoreCase))
                {
                    // The user will exit the program when they have entered the number 4
                    playing = false;
                }
                else
                {   
                    // Any other input other than 1,2 or 3 results in Invalid message
                    Console.WriteLine($"Invalid input. \n {initialIntro}");
                }

            }
        }
        private void PickUpItem()
        {
            string item = currentRoom.GetItem();
            bool ownItem = player.DoesItemExist(item);
            if (ownItem)
            {
                Console.WriteLine("You already have this item");
            }
            else
            {
                //if ownItem is false- item doesnt exist in inventory, Item is successfully added to the inventory
                player.PickUpItem(item);
                Console.WriteLine($"You have successfully picked up item: {item}");
            }
        }
    }
}

