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
            Player player = new Player();
            Console.WriteLine("Please enter your name: ");
            string name=Console.ReadLine();
            player.Players(name);
        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            while (playing)
            {
                // Code your playing logic here
            }
        }
    }
}
