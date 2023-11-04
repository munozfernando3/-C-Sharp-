using System;
using System.Data.Common;
using System.Dynamic;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<dynamic> robots = new List<dynamic>();
            int i = 0;
            while (i < 5)
            {
                i++;
                dynamic robot = new ExpandoObject();
                robot.ID = i;
                robot.Name = RobotSystem.AskForName();
                robot.Size = RobotSystem.AskForSize();
                robot.Color = RobotSystem.AskForColor();
                robots.Add(robot);
                foreach (dynamic r in robots)
                {
                    Clear();
                    WriteLine("Robot #" + r.ID);
                    WriteLine("-----------------");
                    foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)r)
                    {
                        if (property.Value != null)
                        {
                            WriteLine($"{property.Key}: {property.Value}");
                        }
                    }
                    WriteLine("-----------------");
                }
                Write("Press enter to create another robot: ");
                ReadKey();
            }

        }

        public static dynamic? AskForValue(string text)
        {
            Clear();
            Write(text);
            return ReadLine();
        }
    }
    public static class RobotSystem
    {
        public static string name = "Do you want to name this robot?";
        public static string size = "Does this robot have a specific size?";
        public static string color = "Does this robot need to be a specific color?";


        public static bool hasName;
        public static bool hasSize;
        public static bool hasColor;
        public static dynamic? AskForName()
        {
            hasName = Options.Create("Yes", "No", RobotSystem.name);
            if (hasName)
            {
                return Program.AskForValue("What is its name?: ");
            }
            else
            {
                return null;
            }
        }
        public static dynamic? AskForSize()
        {

            hasSize = Options.Create("Yes", "No", RobotSystem.size);
            if (hasSize)
            {
                return Program.AskForValue("What is its size: ");
            }
            else
            {
                return null;
            }
        }
        public static dynamic? AskForColor()
        {

            hasSize = Options.Create("Yes", "No", RobotSystem.color);
            if (hasSize)
            {
                return Program.AskForValue("What is its color: ");
            }
            else
            {
                return null;
            }
        }
    }
    public static class Options
    {
        static bool n = true;
        public static bool Create(string a, string b, string text)
        {
            while (true)
            {
                Clear();
                ResetColor();
                WriteLine(text);
                if (n)
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(a);
                    ResetColor();
                    WriteLine($"{b,25}");
                }
                else
                {

                    Write(a);
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"{b,25}");
                    ResetColor();
                }
                ConsoleKey k = ReadKey().Key;
                if (k == ConsoleKey.LeftArrow && n == false)
                {
                    n = true;
                    continue;
                }
                else if (k == ConsoleKey.RightArrow && n == true)
                {
                    n = false;
                    continue;
                }
                else if (k == ConsoleKey.Enter)
                {
                    return n;
                }
            }
        }
        public static void DisplayColor()
        {

        }

    }
    public static class Adds
    {
        public static dynamic Add(dynamic a, dynamic b) => a + b;
    }

}