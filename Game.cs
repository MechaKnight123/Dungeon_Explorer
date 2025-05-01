using System;
using System.Media;
using System.Collections.Generic;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private GameMap gameMap;

        //Dictionary is used to create key pair values that will be used when user uses an items in inventory
        //maps strings and objects
        private Dictionary<string, Item> allItems = new Dictionary<string, Item>(StringComparer.OrdinalIgnoreCase);
        

        public Game()
        {
            gameMap = new GameMap();
            
        }
        public void Start()
        {
            allItems.Add("Welcome Mat", new WelcomeMat("Welcome Mat", 30));
            allItems.Add("Diamond Sword", new DiamondSword("Diamond Sword", 50));
            allItems.Add("Poison Potion", new PoisonPotion("Poison Potion", 35));
            allItems.Add("Fireball potion", new FireballPotion("Fireball potion", 40));
            allItems.Add("Healing potion", new HealingPotion("Healing potion", 100));
            allItems.Add("Leafblower", new LeafBlower("Leafblower", 10));
            allItems.Add("Canon", new Canon("Canon", 55));

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
                //sets up currentRoom and tells the user where they are
                Room currentRoom = gameMap.CurrentRoom;
                Console.WriteLine($"You are currently in {currentRoom.name} and the item in the room is {currentRoom.ItemInRoom.itemName}");

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

                //Outputs the name of the Monster in the room
                if (currentRoom.Occupant != null)
                {
                    Console.WriteLine($"A {currentRoom.Occupant.Name} is here!");

                }
                else
                {
                    Console.WriteLine("There is no Monsters in the room");
                }

                //Asking the user if they would like to attack the monster
                Console.WriteLine($"Would you like to attack the {currentRoom.Occupant?.Name}? (Y/N)");
                string attackChoice = Console.ReadLine()?.Trim().ToUpper();

                if (attackChoice == "Y")
                {
                    Console.Write("What item do you want to use? ");
                    string itemToUse = Console.ReadLine()?.Trim();

                    //once the user decides what item to use,the appropriate operation will be carried out
                    if (string.IsNullOrWhiteSpace(itemToUse))
                    {
                        Console.WriteLine("No item input received.");
                    }
                    //checks if item is in the inventory
                    else if (!player.DoesItemExist(itemToUse))
                    {
                        Console.WriteLine("That item is not in your inventory.");
                    }
                    //check if item is missing in dictionary
                    else if (!allItems.TryGetValue(itemToUse, out Item item))
                    {
                        Console.WriteLine("Item exists in inventory, but not found in master dictionary.");
                    }
                    //checks if there is a monster in the room
                    else if (!(currentRoom.Occupant is Monster monster))
                    {
                        Console.WriteLine("There is no monster in this room to attack.");
                    }
                    else
                    {
                        // All checks passed — use the item
                        int effect = item.Use(player, monster);

                        if (item is HealingPotion)
                        {
                            // Healing logic already handled inside Use()
                        }
                        else
                        {
                            // Attack the monster
                            player.Attack(monster, effect);
                        }
                    }

                    
                    
                        
                    
                }
                else
                {
                    Console.WriteLine($"You have not attacked the{currentRoom.Occupant.Name} this turn");
                }

                //the user will move to the next room if the monster's health is 0 or less
                if (currentRoom.Occupant.Health <= 0)
                {
                    gameMap.MoveToNextRoom();
                    //breaks the loop once the user defeats the final monster
                    if (currentRoom.Occupant is Tower tiger)
                        {
                             break;
                        }
                }
                else if (currentRoom.Occupant is Monster monster && currentRoom.Occupant.Health > 0)
                {
                    //if the monster's health is not 0 then the monster will attack the user every turn
                    int damage = monster.monsterDamage(currentRoom.Occupant.Name);
                    monster.Attack(player, damage);
                    Console.WriteLine(player.Health);
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
                
            
            }


        }

    }
}

