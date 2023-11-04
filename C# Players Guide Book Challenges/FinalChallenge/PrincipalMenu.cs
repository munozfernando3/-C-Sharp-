namespace MyApp // Note: actual namespace depends on the project name.
{
    public class PrincipalMenu
    {
        public IGameMode gameMode;
        Menu menu = new Menu("BATTLE GAME", "PLAYER VS COMPUTER", "PLAYER VS PLAYER");
      
        public void Display()
        {
            while (true)
            {
                menu.Display();
                if (menu.SelectedOption(1))
                {
                    gameMode = new PlayerVsComputerMode();
                    break;
                }
                else
                {
                    continue;
                }


            }
        }

    }
    public record Game()
    {
        PrincipalMenu menu= new PrincipalMenu();
        public void Start()
        {
            menu.Display();
            menu.gameMode.Start();
        }
    }
}