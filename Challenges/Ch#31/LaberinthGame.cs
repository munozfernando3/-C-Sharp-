namespace Map // Note: actual namespace depends on the project name.
{
    public class LaberinthGame
    {

        Level[] levels = new Level[10];
        GameIntroDesign intro = new GameIntroDesign();

        public LaberinthGame()
        {
            intro.StartEasyGame += StartGame;
            intro.DisplayMenu();

        }
        public void StartGame()
        {
            AddLevels();
            for (int x = 0; x < levels.Length; x++)
            {
                levels[x].Start();
            }
        }
        public void AddLevels()
        {
            int mapSize = 3;
            for (int x = 0; x < levels.Length; x++, mapSize++)
            {
                CreateLevel(x, mapSize);
            }
        }
        public void CreateLevel(int x, int mapSize)
        {
            levels[x] = new Level(x + 1, mapSize);
        }

    }
    public class GameIntroDesign
    {
        private Menu Principalmenu = new Menu("Rooms Game", "Play", "How To Play", "Exit");
        private Menu DifficultyMenu = new Menu("Select the dificulty", "Easy", "Normal", "Hard", "Extreme", "BACK");
        public event Action? StartEasyGame;

        public event Action? StartnNormalGame;

        public void DisplayPrincipalMenu()
        {
            EditPrincipalMenu();
            Principalmenu.Display();
        }
        public void DisplayDificultyMenu()
        {
            EditDifficultyMenu();
            DifficultyMenu.Display();
            if (DifficultyMenu.SelectedOption(1))
            {
                StartEasyGame();
            }
            else if (DifficultyMenu.SelectedOption(5))
            {
                DisplayMenu();
            }
            else
            {
                StartEasyGame();
            }

        }
        public void DisplayMenu()
        {
            DisplayPrincipalMenu();
            if (Principalmenu.SelectedOption(1))
            {
                DisplayDificultyMenu();
            }
            else if (Principalmenu.SelectedOption(2))
            {
                DisplayHelp();
            }
            else
            {
                ResetColor();
            }
        }
        public void DisplayHelp()
        {

        }
        public void EditPrincipalMenu()
        {
            Principalmenu.AssignColorToOption(1, Yellow);
            Principalmenu.AssignColorToOption(2, DarkGreen);
            Principalmenu.AssignColorToOption(3, Red);
        }
        public void EditDifficultyMenu()
        {
            DifficultyMenu.AssignOneSingleColor(Blue);
        }

    }
}
