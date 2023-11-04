namespace Map // Note: actual namespace depends on the project name.
{
    public class EntryCavern : ITypeOfRoom
    {
        public string Name { get; }

        public ConsoleColor Color { get; }

        public string Text { get; }
        public EntryCavern()
        {
            Name = "Starting room";
            Text = "This is the starting room. Find the key, and then the exit room to scape from this Laberinth. (The EXIT is at the edge)";
            Color = ConsoleColor.DarkCyan;
        }
    }

}
