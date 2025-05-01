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







    }


}