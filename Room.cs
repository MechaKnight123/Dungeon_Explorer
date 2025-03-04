namespace DungeonExplorer
{
    public class Room
    {
        private string description;

        public string Rooms(string description)
        {
            this.description = description;
            return description;
        }

        public string GetDescription(string RoomName)
        {
           string description = "A bedroom with a single bed, a desk, a cupboard and chairs";
            if (RoomName == "bathroom")
            {
                description = "A bathroom with a single toilet, a bathtub, a cupboard and a sink";
            }
            else if (RoomName =="dining room")
            {
                description = "A dining room with a dining table,  cutlery and drawers ";
            }
            //in main program, use try and catch to prevent user from entering ints or dec, and ensure inputs are: bedroom,bathroon,diningroom
            return description;
        }
    }
}