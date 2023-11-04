using System.Threading.Tasks.Dataflow;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        public static class ConsoleColor
        {
            public static string? Prompt(string a)
            {
                Write(a);
                ForegroundColor=System.ConsoleColor.Cyan;
                return ReadLine();
            }
            
        }
    }
}