using System;
using System.Media;
using System.Collections.Generic;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private GameMap gameMap;
        

        public Game()
        {
            gameMap = new GameMap();
             
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
            else
            {
                Console.WriteLine("Welcome to Dungeon Explorer");
            }

            playing = true;
            Console.Write("Enter your name: ");
            string playersName = Console.ReadLine();
            player = new Player(playersName,100); // Player object has been created with name inputted by user and health set to 100
            while (playing)
            {
                Room currentRoom = gameMap.CurrentRoom;
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
            Room room = gameMap.CurrentRoom;
            //when user wants to pick up an item that doesnt exist, this message will be returned
            if (room.ItemInRoom == null)
            {
                Console.WriteLine("There is no item in this room.");
                return;
            }

            string itemName = room.ItemInRoom.itemName;
            bool ownItem = player.DoesItemExist(itemName);
            if (ownItem)
            {
                Console.WriteLine("You already have this item");
            }
            else
            {
                //if ownItem is false- item doesnt exist in inventory, Item is successfully added to the inventory
                room.ItemInRoom.OnCollect(player); // Adds item via the item class
                Console.WriteLine($"You have successfully picked up item: {itemName}");
                room.ItemInRoom = null; // Remove item from room after pickup
               
            }
        }
    }
}

