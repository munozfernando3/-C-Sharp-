using System;
using static System.Console;
using static System.ConsoleColor;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program2
    {
        static void Main2(string[] args)
        {
Clear();
        PasswordValidator.Validate();
        }
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
    }
    public static class PasswordValidator
    {
        public static string? Password { get; set; }

        public static List<string>? FullfilledRequirements = new List<string>();

        public static List<string>? UnFullfilledRequirements = new List<string>();

        public static string AskForPassword()
        {
            Write("Password: ");
            return ReadLine();
        }
        public static void Validate()
        {
            while (true)
            {
                FullfilledRequirements.Clear();
                UnFullfilledRequirements.Clear();
                Password = AskForPassword();
                bool hasAtLeast6Characters=HasAtLeast6Characters();
                bool hasNoMoreThan13Characters=HasNoMoreThan13Characters();
                bool hasSpecialCharacters=HasSpecialCharacters();
                bool hasTOrAmpersand=HasTOrAmpersand();
                if (hasAtLeast6Characters && hasNoMoreThan13Characters && hasSpecialCharacters &&hasTOrAmpersand)
                {
                    Clear();
                    break;
                }
                else
                {
                    Clear();
                    DisplayRequirements();
                    continue;
                }
            }
        }

        public static bool HasAtLeast6Characters()
        {
            if (Password.Length >=6 )
            {
                FullfilledRequirements.Add("The password has at least 6 characters");
                return true;
            }
            else 
            {
                UnFullfilledRequirements.Add("The password does not have at least 6 characters");
                return false;
            }


        }
        public static bool HasNoMoreThan13Characters()
        {
            if (Password.Length <= 13)
            {
                FullfilledRequirements.Add("The password has no more than 13 characters");
                return true;
            }
            else
            {
                UnFullfilledRequirements.Add("The password is too long");
                return false;
            }
        }
        public static bool HasSpecialCharacters()
        {
            bool hasUpperCase = false;
            bool hasNumber = false;
            bool hasLowerCase = false;
            for (int x = 0; x < Password.Length; x++)
            {
                if (Char.IsUpper(Password[x]))
                {
                    hasUpperCase = true;
                }
                if (Char.IsLower(Password[x]))
                {
                    hasLowerCase = true;
                }
                if (Char.IsNumber(Password[x]))
                {
                    hasNumber = true;
                }
            }
            if (hasLowerCase && hasUpperCase && hasNumber)
            {
                FullfilledRequirements.Add("The password contains at least one uppercase, one lowercase and one number");
                return true;
            }
            else
            {
                UnFullfilledRequirements.Add("The password must contain at least one uppercase, one lowercase and one number");
                return false;
            }
        }
        public static bool HasTOrAmpersand()
        {
            for (int x = 0; x < Password.Length; x++)
            {
                if (Password[x] == 'T' || Password[x] == '&')
                {
                    UnFullfilledRequirements.Add("The password can not have a 'T' or a '&'");
                    return false;
                }
            }
            FullfilledRequirements.Add("The password do not have a 'T' or a '&'");
            return true;


        }
        public static void DisplayRequirements()
        {
            for (int x = 0; x < FullfilledRequirements.Count; x++)
            {
                Program2.ColorWriteLine(FullfilledRequirements[x], Green);
            }
            for (int x = 0; x < UnFullfilledRequirements.Count; x++)
            {
                Program2.ColorWriteLine(UnFullfilledRequirements[x], Red);
            }
        }

    }
}