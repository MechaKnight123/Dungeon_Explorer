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

    }
}