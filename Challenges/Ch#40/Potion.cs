namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Potion 
    {
        private ConsoleColor _color;
        public TypeOfPotion typeOfPotion;
        public ConsoleColor Color
        {
            get
            {
                if (typeOfPotion==TypeOfPotion.Water)
                {
                    _color=Cyan;
                }
                else if (typeOfPotion==TypeOfPotion.Elixir)
                {
                    _color=DarkGreen;
                }
                 else if (typeOfPotion==TypeOfPotion.PoisonPotion)
                {
                    _color=DarkMagenta;
                }

               else if (typeOfPotion==TypeOfPotion.FlyingPotion)
                {
                    _color=Yellow;
                }
                 else if (typeOfPotion==TypeOfPotion.InvisibililyPotion)
                {
                    _color=DarkGray;
                }
                 else if (typeOfPotion==TypeOfPotion.NightSightPotion)
                {
                    _color=DarkBlue;
                }
                 else if (typeOfPotion==TypeOfPotion.WraithPotion)
                {
                    _color=DarkYellow;
                }
                 else if (typeOfPotion==TypeOfPotion.CloudyBrew)
                {
                    _color=ConsoleColor.Cyan;
                }
                 else if (typeOfPotion==TypeOfPotion.RuinedPotion)
                {
                    _color=Red;
                }
                return _color;
            }
        }


        public Potion()
        {
            typeOfPotion=TypeOfPotion.Water;
            
        }
        public void DisplayPotion()
        {
 
            Facilities.ColorWriteDescription("Current Potion: ", Program.ConvertToToLogicalString(typeOfPotion.ToString()), Color);
            WriteLine(" ");
        
        }
    }
}