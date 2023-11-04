global using static System.Console;
global using static System.ConsoleColor;
public static class Facilities
{
    public static void ColorWriteLine(string message, ConsoleColor color)
    {
        ForegroundColor = color;
        WriteLine(message);
        ResetColor();
    }
    public static void ColorWrite(string message, ConsoleColor color)
    {
        ForegroundColor = color;
        Write(message);
        ResetColor();
    }
    public static void ColorWriteLineAlignment(string message, ConsoleColor color)
    {
        ForegroundColor = color;
        Write($"{message,-30}");
        ResetColor();
    }
    public static void ColorWriteDescriptionAlignment(string header, string text, ConsoleColor color)
    {
        ForegroundColor = color;
        Write($"{header}");
        ResetColor();
        Write($"{text,-20}");
    }
    public static void ColorWriteDescription(string header, string text, ConsoleColor color)
    {
        ForegroundColor = color;
        Write(header);
        ResetColor();
        WriteLine(text);
    }


    public static void PerformCountdownAction(int interval, int secondperAction, int value, ref int factor)
    {
        DateTime date = DateTime.Now;
        DateTime duration = date.AddSeconds(interval);
        DateTime xsecondAfter = DateTime.Now.AddSeconds(secondperAction);
        while (DateTime.Now < duration)
        {
            if (DateTime.Now >= xsecondAfter)
            {
                Clear();
                xsecondAfter = DateTime.Now.AddSeconds(1);
            }
        }
    }
    public class Menu
    {
        private List<Option> _options = new List<Option>();
        private string _title;
        private string _arrow = "=>";

        private int _selectIndex = 0;
        private bool _isColorFull = false;

        private bool _isColorLess = false;

        private bool _hasDefaultDesign = true;

        private int _colorIndex;

        private DisplaySomething _extraInformation = NonExtraInformation;

        private ConsoleColor[] _colors = new ConsoleColor[11] { Blue, Yellow, Green, Magenta, Cyan, Red, DarkYellow, DarkBlue, DarkGreen, DarkMagenta, DarkCyan };

        public int ColorIndex
        {
            get
            {
                if (_colorIndex >= _colors.Length)
                {
                    _colorIndex = 0;
                }

                return _colorIndex;

            }
        }

        public int SelectIndex
        {
            get
            {
                if (_selectIndex >= _options.Count)
                    _selectIndex = 0;
                else if (_selectIndex < 0)
                    _selectIndex = _options.Count - 1;
                return _selectIndex;
            }
        }

        public Menu(string title)
        {
            _title = title;
            _colorIndex = 0;
        }
        public Menu(string title, params string[] options)
        {
            _title = title;
            Option[] arrayOfOptions = new Option[options.Length];
            for (int x = 0; x < options.Length; x++, _colorIndex++)
            {
                arrayOfOptions[x] = new Option(options[x], _colors[ColorIndex]);
            }
            _options.AddRange(arrayOfOptions);
        }
        public Menu(string title, DisplaySomething extraInformation, params string[] options)
        {
            _title = title;
            _extraInformation = extraInformation;

            Option[] arrayOfOptions = new Option[options.Length];
            for (int x = 0; x < options.Length; x++, _colorIndex++)
            {
                arrayOfOptions[x] = new Option(options[x], _colors[ColorIndex]);
            }
            _options.AddRange(arrayOfOptions);
        }
        private void DisplayTitle()
        {
            ForegroundColor = Magenta; //Muy bien army
            WriteLine($"{_title,30}");
        }
        private void DisplayOption(Option option, int index)
        {
            if (_hasDefaultDesign)
            {
                ForegroundColor = option.Color;
                Write($"{index + 1,5}" + ".-");
                ResetColor();
                WriteLine(option.Value);
            }
            else if (_isColorFull)
            {
                ForegroundColor = option.Color;
                WriteLine(index + 1 + ".- " + option.Value);
                ResetColor();
            }
            else
            {
                ResetColor();
                DisplayArrow(index, option);
                WriteLine($"{index + 1,5}" + ".- " + option.Value);
            }
        }
        private void DisplayArrow(int index, Option option)
        {
            if (SelectIndex == index)
            {
                ForegroundColor = option.Color;
                Write($"{"=>"}");
            }
            else
                Write("  ");
        }
        private void DisplayOptions()
        {
            for (int x = 0; x < _options.Count; x++)
            {
                DisplayOption(_options[x], x);
            }
        }

        public void DisplayMenu()
        {
            DisplayTitle();
            DisplayOptions();
        }
        public void ColorLessMenu()
        {
            MakeColorLess();
            DisplayTitle();
            DisplayOptions();
        }
        public void ColorFullMenu()
        {
            MakeColorfull();
            DisplayTitle();
            DisplayOptions();
        }
        public void Display(DisplaySomething typeOfMenu)
        {
            while (true)
            {
                typeOfMenu();
                ConsoleKey key = ReadKey().Key;
                if (key == ConsoleKey.DownArrow)
                {
                    _selectIndex++;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    _selectIndex--;
                }
                if (key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
        public void Display()
        {
            while (true)
            {
                Clear();
                _extraInformation();
                ColorLessMenu();
                ConsoleKey key = ReadKey().Key;
                if (key == ConsoleKey.DownArrow)
                {
                    _selectIndex++;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    _selectIndex--;
                }
                if (key == ConsoleKey.Enter)
                {
                    break;
                }
            }

        }
        public void AddUpperInformation()
        {

        }

        public void AddOption(string option)
        {

            _options.Add(new Option(option, _colors[ColorIndex]));
            _colorIndex++;
        }
        public bool SelectedOption(int index)
        {
            Clear();
            return SelectIndex + 1 == index;
        }
        private void MakeColorfull()
        {
            _hasDefaultDesign = false;
            _isColorLess = false;
            _isColorFull = true;
        }
        private void MakeColorLess()
        {
            _hasDefaultDesign = false;
            _isColorLess = true;
            _isColorFull = false;
        }

        private void SetDeafultDesign()
        {
            _hasDefaultDesign = true;
            _isColorLess = false;
            _isColorFull = false;
        }
        public static void NonExtraInformation()
        {

        }

    }
    public class Option
    {
        private string _value;
        private ConsoleColor _color;

        public string Value { get => _value; set => _value = value; }
        public ConsoleColor Color { get => _color; set => _color = value; }
        public Option(string value, ConsoleColor color)
        {
            _value = value;
            _color = color;
        }
    }
    public delegate void DisplaySomething();
}