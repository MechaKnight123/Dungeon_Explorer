using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        
        
        public Game()
        {
            // Initialize the game with one room and one player
            
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
            Console.WriteLine("Enter your name: ");
            string playersName = Console.ReadLine();
            player = new Player(playersName, 5); // Player object has been created with name inputted by user and health of 5 set by default

            while (playing)
            {
                // Code your playing logic here

            }
        }
    }
}

