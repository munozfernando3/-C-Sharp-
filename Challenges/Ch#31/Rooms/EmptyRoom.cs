namespace Map // Note: actual namespace depends on the project name.
{
    public class EmptyRoom : ITypeOfRoom
    {
        public string Name { get; set;}

        public ConsoleColor Color { get; set;}

        public string Text { get; set;}
        public EmptyRoom()
        {
            Name = "Empty Room";
            Text = "You can not feel, or smell anything. You are in an empty room. Keep going!";
            Color = ConsoleColor.Green;
        }
        public EmptyRoom(string warning)
        {
            Name = "Empty Room. WARNING!";
            Text = "You hear the sound of a bunch of snakes. Be careful!. You better back off";
            Color = ConsoleColor.Yellow; 
        }
    }
    public class WarningRoom : EmptyRoom
    {
        public Trap TrapNeighborRoom;
        public WarningRoom(Trap trapRoom)
        {
            TrapNeighborRoom=trapRoom;
            Name = "Empty Room. WARNING!";
            Text = " ";
            Color = ConsoleColor.Yellow; 
        }
        public void AssignCorrespondingWarningMessage()
        {
          
        }
        public string pitWarning="You hear the sound of a bunch of snakes. Be careful!. You better back off";
     
        
    }
    
}