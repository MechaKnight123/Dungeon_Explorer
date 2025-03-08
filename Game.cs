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
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            Console.WriteLine("Are you ready to start? Enter y/n");
            string input = Console.ReadLine();
            if (!string.Equals("y", input, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            while (playing)
            {
                // Code your playing logic here

            }
        }
    }
}

