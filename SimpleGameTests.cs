using System;

namespace DungeonExplorer
{
    public static class ManualTests
    {
        //will be used in program file to run all tests and ensure everything works as intended
        public static void RunAll()
        {
            Console.WriteLine("Running manual tests...\n");

            //tests to be run should be run below
            Test_PlayerCanPickUpItem();
            Test_WeaponDamagesMonster();
            Test_PlayerInventoryShowsCorrectly();
            Test_RoomOccupantIsStored();

            Console.WriteLine("\n All manual tests completed.");
        }

        //used to check if the player can pick up an item - just used Welcome Mat as an example
        private static void Test_PlayerCanPickUpItem()
        {
            var player = new Player("TestPlayer", 100);
            var item = new WelcomeMat("Welcome Mat", 10);
            item.OnCollect(player);
            
            Console.WriteLine(player.DoesItemExist("Welcome Mat")//if true, a message saying that this function has passed will be displayed
                ? "Test_PlayerCanPickUpItem passed."
                : "Test_PlayerCanPickUpItem failed.");
        }

        //used to check effect of a weapon being used on a monster
        private static void Test_WeaponDamagesMonster()
        {
            //setting up test variables to see effect of a weapon being used on a monster
            var player = new Player("TestPlayer", 100);
            var monster = new Dragon("Test Dragon", 100);
            var weapon = new DiamondSword("Diamond Sword", 50);

            int damage = weapon.Use(player, monster);
            player.Attack(monster, damage);

            Console.WriteLine(monster.Health < 100//if the monster's health goes down after using the weapon then this test will be successful
                ? "Test_WeaponDamagesMonster passed."
                : "Test_WeaponDamagesMonster failed.");
        }

        //ensuring that user can pick up an item and add it to their inventory
        private static void Test_PlayerInventoryShowsCorrectly()
        {
            var player = new Player("TestPlayer", 100);
            var sword = new DiamondSword("Diamond Sword", 50);
            sword.OnCollect(player);

            Console.WriteLine(player.InventoryContents().Contains("Diamond Sword")
                ? "Test_PlayerInventoryShowsCorrectly passed."
                : "Test_PlayerInventoryShowsCorrectly failed.");
        }

        //Checking if Occupant in the GameMap file for each room is stored correctly
        private static void Test_RoomOccupantIsStored()
        {
            var room = new Room("Room desc", "Item desc", "Room name", "Key");
            var monster = new Dragon("Dragon", 80);
            room.Occupant = monster;

            Console.WriteLine(room.Occupant?.Name == "Dragon"
                ? "Test_RoomOccupantIsStored passed."
                : "Test_RoomOccupantIsStored failed.");
        }



    }


}