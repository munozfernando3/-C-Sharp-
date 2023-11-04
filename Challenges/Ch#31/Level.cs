namespace Map // Note: actual namespace depends on the project name.
{
    public class Level
    {
        public Level(int levelNumber, int size)
        {
            LevelNumber = levelNumber;
            Size = size;
        }

        public int LevelNumber { get; }
        public SquareMap Map { get; set; }
        public bool IsComplete { get; set; }
        public int Size { get; }

        private int _numberOfTries;

        public void Start()
        {

            while (!IsComplete)
            {
                Map = new SquareMap(Size);
                IsComplete = false;
                while (true)
                {
                    Display();
                    ConsoleKey key = ReadKey().Key;
                    if (Map.Loose())
                    {
                       
                        if (key == ConsoleKey.Enter)
                        {
                        _numberOfTries++;
                            break;
                        }
                                 
                    }
                    
                    else
                    {
                        if (key == ConsoleKey.RightArrow)
                        {
                            Map.MoveEast();
                        }
                        if (key == ConsoleKey.LeftArrow)
                        {
                            Map.MoveWest();
                        }
                        if (key == ConsoleKey.UpArrow)
                        {
                            Map.MoveNorth();
                        }
                        if (key == ConsoleKey.DownArrow)
                        {
                            Map.MoveSouth();
                        }
                        if (key == ConsoleKey.Enter)
                        {
                            Map.TakeKey();
                            if (Map.Complete())
                            {
                                IsComplete = true;
                                break;
                            }
                        }
                    }
                }

            }
        }
        public void Display()
        {
            Clear();
            DisplayLevelNumber();
            Map.Display();
            DisplayStatistics();
        }
        public void DisplayStatistics()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            Write("Traps: " + Map.GetNumberOfTrapRooms());
            WriteLine($"{"Tries: ",20}"+_numberOfTries);
            

        }
        public void DisplayLevelNumber()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Level " + LevelNumber);
            ResetColor();
        }
    }

}

