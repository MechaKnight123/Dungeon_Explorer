using System;
using System.Collections.Generic;


namespace DungeonExplorer
{
    public class Room
    {
        private string name;
        private string description;
        private string item;
        

        public Room(string description, string item, string name)
        {
            this.description = description;
            this.item = item;
            this.name = name;
            
        }

        //Returns description of the room
        public string GetDescription()
        {
            return description;
        }

        //Return item
        public string GetItem()
        {
            return item;
        }

        //Returns the name of the room
        public string GetName()
        {
            return name;
        }


    }

    //public class GameMap
    //{
        //private string roomName;
        //roomList
      //  public GameMap(string roomName)
        //{
            //take room name as argument-validate using ifs
            //create a list of rooms
            //takes room as parameter-could use inheritance
            //could take list of rooms as parameter- define twice --> make it private here and use this.list=list--> this list is created in the game by using .Add function
            

        //}

        // public string GetRoom(){
        //return roomName;
        // }


       // public bool DoesRoomExist()
        //{
            //use lambda function like DoesItemExist
            
        //}

    //}
}