global using static System.Console;
global using static System.ConsoleColor;
using System.Security.Cryptography.X509Certificates;

public static class Facilities
{

    public static class User<T>
    {
        public static T AskForValue(string message, ConsoleColor color)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = color;
                    Write(message + ": ");
                    ResetColor();
                    string? answer = ReadLine();
                    return (T)Convert.ChangeType(answer, typeof(T));
                }
                catch
                {
                    WriteLine("That is not a valid value. Try Again");
                    Clear();
                }
            }
        }
    }
    public static string ObjectToString(object enumeration)
    {
        string? s = enumeration.ToString();
        string y = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                y += " ";
            }
            y += s[i];
        }
        return y;

    }
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

}
public class Menu
{
    private List<Option> _options = new List<Option>();
    private string _title;
    private string _arrow = "=>";

    private int _selectIndex = 0;

    private int _colorIndex;

    private DisplaySomething __extraUpperInformation = NonextraUpperInformation;
    private DisplaySomething _extraLowerInformation = Instructions;

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
    public Menu(string title, DisplaySomething extraUpperInformation, params string[] options)
    {
        _title = title;
        __extraUpperInformation = extraUpperInformation;

        Option[] arrayOfOptions = new Option[options.Length];
        for (int x = 0; x < options.Length; x++, _colorIndex++)
        {
            arrayOfOptions[x] = new Option(options[x], _colors[ColorIndex]);
        }
        _options.AddRange(arrayOfOptions);
    }
    public Menu(string title, DisplaySomething extraUpperInformation, DisplaySomething extraLowerInformation, params string[] options)
    {
        _title = title;
        __extraUpperInformation = extraUpperInformation;
        _extraLowerInformation = extraLowerInformation;

        Option[] arrayOfOptions = new Option[options.Length];
        for (int x = 0; x < options.Length; x++, _colorIndex++)
        {
            arrayOfOptions[x] = new Option(options[x], _colors[ColorIndex]);
        }
        _options.AddRange(arrayOfOptions);
    }
    private void DisplayTitle()
    {
        ForegroundColor = Magenta;
        WriteLine($"{_title,30}");
        WriteLine(" ");
    }
    private void DisplayOption(Option option, int index)
    {
        ResetColor();
        DisplayArrow(index, option);
        WriteLine($"{index + 1,5}" + ".- " + option.Value);
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
            WriteLine(" ");
        }
    }

    public void DisplayMenu()
    {
        DisplayTitle();
        DisplayOptions();
    }

    public void Display()
    {
        while (true)
        {
            Clear();
            __extraUpperInformation();
            DisplayMenu();
            _extraLowerInformation();
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
    public void EditStatus(DisplaySomething information)
    {
        __extraUpperInformation = information;
    }
    public void AddOption(string option)
    {

        _options.Add(new Option(option, _colors[ColorIndex]));
        _colorIndex++;
    }
    public void AddExit()
    {

        _options.Add(new Option("EXIT", DarkRed));
        _colorIndex++;
    }
    public void AddSpecificColorOption(string option, ConsoleColor color)
    {
        _options.Add(new Option(option, color));
        _colorIndex++;
    }
    public bool SelectedOption(int index)
    {
        Clear();
        return SelectIndex + 1 == index;
    }
    public void AssignOneSingleColor(ConsoleColor newColor)
    {
        for (int x = 0; x < _options.Count; x++)
        {
            _options[x].Color = newColor;
        }
    }
    public void AssignColorToOption(int index, ConsoleColor newColor)
    {
        _options[index - 1].Color = newColor;
    }

    public static void NonextraUpperInformation()
    {

    }
    public static void Instructions()
    {
        Facilities.ColorWriteLine("Press Enter to select an option. Use ↑ and ↓ to move", DarkGray);
    }


}
public class LinearMenu<T>
{
    private List<Option<T>> _options = new List<Option<T>>();
    private int _selectIndex = 0;

    private int _colorIndex;

    private DisplaySomething __extraUpperInformation = NonextraUpperInformation;
    private DisplaySomething _extraLowerInformation;

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

    public LinearMenu(params T[] options)
    {
        Option<T>[] arrayOfOptions = new Option<T>[options.Length];
        for (int x = 0; x < options.Length; x++, _colorIndex++)
        {
            arrayOfOptions[x] = new Option<T>(options[x], ConsoleColor.DarkBlue);
        }
        _options.AddRange(arrayOfOptions);
    }
    public LinearMenu( DisplaySomething extraUpperInformation, params T[] options)
    {
        __extraUpperInformation = extraUpperInformation;
        Option<T>[] arrayOfOptions = new Option<T>[options.Length];
        for (int x = 0; x < options.Length; x++)
        {
            arrayOfOptions[x] = new Option<T>(options[x], DarkCyan);
        }
        _options.AddRange(arrayOfOptions);
    }
    public LinearMenu( DisplaySomething extraUpperInformation, DisplaySomething extraLowerInformation, params T[] options)
    {
        __extraUpperInformation = extraUpperInformation;
        _extraLowerInformation = extraLowerInformation;

        Option<T>[] arrayOfOptions = new Option<T>[options.Length];
        for (int x = 0; x < options.Length; x++)
        {
            arrayOfOptions[x] = new Option<T>(options[x], DarkBlue);
        }
        _options.AddRange(arrayOfOptions);
    }
    private void DisplayOption(Option<T> option, int index)
    {
        
        if (SelectIndex == index)
        {
            ForegroundColor = option.Color;
        }
        Write($"{Facilities.ObjectToString(option.Value.GetType().Name)}");
        Write($"{" ",15}");
        ResetColor();

    }

    private void DisplayOptions()
    {
        for (int x = 0; x < _options.Count; x++)
        {
            DisplayOption(_options[x], x);
        }
    }

    private void DisplayMenu()
    {
        DisplayOptions();
        WriteLine(" ");
    }

    public void Display()
    {
        while (true)
        {
            Clear();
            __extraUpperInformation();
            DisplayMenu();
            ConsoleKey key = ReadKey().Key;
            if (key == ConsoleKey.RightArrow)
            {
                _selectIndex++;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                _selectIndex--;
            }
            if (key == ConsoleKey.Enter)
            {
                break;
            }
        }

    }
    public T GetValue()
    {
 return _options[SelectIndex].Value;
    }
    public void AddUpperInformation()
    {

    }
    public void EditStatus(DisplaySomething information)
    {
        __extraUpperInformation = information;
    }
    public void AddOption(T option)
    {

        _options.Add(new Option<T>(option, DarkBlue));
        _colorIndex++;
    }
    
    public bool SelectedOption(int index)
    {
        Clear();
        return SelectIndex + 1 == index;
    }
    public void AssignOneSingleColor(ConsoleColor newColor)
    {
        for (int x = 0; x < _options.Count; x++)
        {
            _options[x].Color = newColor;
        }
    }
    public void AssignColorToOption(int index, ConsoleColor newColor)
    {
        _options[index - 1].Color = newColor;
    }

    public static void NonextraUpperInformation()
    {

    }
   


}
public class Option<T>
{
    private T _value;
    private ConsoleColor _color;

    public T Value { get => _value; set => _value = value; }
    public ConsoleColor Color { get => _color; set => _color = value; }
    public Option(T value, ConsoleColor color)
    {
        _value = value;
        _color = color;
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
