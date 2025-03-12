﻿using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        
        
        public Game()
        {
            // Initialize the game with one room with a description, item and a name
            currentRoom = new Room("This is the Precious Patio where unique things happen", "Welcome Mat", "Patio");
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
            player = new Player(playersName, 5); // Player object has been created with name inputted by user and health of 5 set by default

            while (playing)
            {
                //Asks user to enter 1, 2 or 3
                string initialIntro = "Enter 1 to add an item, 2. to view room's description and 3. to get current items and health.";
               
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

