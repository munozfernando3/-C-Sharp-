namespace Map // Note: actual namespace depends on the project name.
{
    public class KeyRoom : ITypeOfRoom
    {
       
        public string Name { get; }

        public ConsoleColor Color { get; }

        private bool _hasKey;

        public string Text { get; }
        public KeyRoom()
        {
            Name = "Key room";
            Text = "You can almost taste the chocolate.You have found the chocolate key!. Press enter to collect the Key";
            Color = ConsoleColor.Magenta; 
            _hasKey=false;
        }
     
        public void HasKey()
        {
            _hasKey=true;
        }
       
    }
}
