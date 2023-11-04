namespace Map // Note: actual namespace depends on the project name.
{
    public class ExitRoom : ITypeOfRoom
    {
        public ExitRoom()
        {
            Name = "Exit room";
            Text = "You feel the metal of a big door handle. You have found the exit room. Press enter to use the key to get out";
            Color = ConsoleColor.Blue;
        }
        public string Name { get; }

        public ConsoleColor Color { get; }

        public string Text { get; }

    }
}