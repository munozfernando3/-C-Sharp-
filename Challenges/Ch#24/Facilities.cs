public class Facilities
{
        public static void ColorWriteLine(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            WriteLine(text);
            ResetColor();
        }
        public static void ColorWrite(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Write(text);
            ResetColor();
        }
        public static void ColorWriteDescription(string header, string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Write(header);
            ResetColor();
            WriteLine(text);
        }
        public static void ColorWriteDescriptionAlignment(string header, string text, ConsoleColor color)
    {
        ForegroundColor = color;
        Write($"{header}");
        ResetColor();
         Write($"{text,-20}");
    }
    public static void WriteAlignment(string text)
    {
         Write($"{text,-20}");
    }
}