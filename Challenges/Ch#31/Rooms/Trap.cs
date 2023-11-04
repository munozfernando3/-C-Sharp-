namespace Map // Note: actual namespace depends on the project name.
{
    public class Trap : ITypeOfRoom
    {
        public string Name { get;  }

        public ConsoleColor Color { get; }

        public string Text { get; }
        public Trap()
        {
            Name = "Trap room: Pit";
            Text = "You have fallen into a snake pit!!. Press Enter to Try Again.";
            Color = ConsoleColor.Red; 
        }
       
    }
    public enum TypeOfTrap
    {


    }
}
