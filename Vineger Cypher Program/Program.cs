using System;
using static System.Console;
using static System.ConsoleColor;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fernando Munoz
            // Helen Lalama
            // Date: 01/17/2022
            // Lab #2: Vineger Cypher

            Test1();
            Test2();
            string start = AskForValidInput("message", Cyan);
            string encryption = AskForValidInput("encryption", Yellow);
            string message = ShiftMesage(start, encryption);
            ForegroundColor = DarkGreen;
            Write("Encrypted message: ");
            ForegroundColor = White;
            WriteLine($"{message}");
        }

        static void Test1()
        {
            Debug.Assert(ShiftChar('a', 'a') == 'a');
            Debug.Assert(ShiftChar('a', 'b') == 'b');
            Debug.Assert(ShiftChar('z', 'b') == 'a');
            Debug.Assert(ShiftChar('u', 'v') == 'p');
            Debug.Assert(ShiftChar('a', 'z') == 'z');
            Debug.Assert(ShiftChar('z', 'c') == 'b');
            Debug.Assert(ShiftChar('z', ' ') == 'z');

        }

        static void Test2()
        {
            Debug.Assert(ShiftMesage("aaa", "aaa") == "aaa");
            Debug.Assert(ShiftMesage("aba", "aba") == "aca");
            Debug.Assert(ShiftMesage("aaa", "a") == "aaa");
            Debug.Assert(ShiftMesage("dog", "aac") == "doi");
            Debug.Assert(ShiftMesage("helen", "ccca") == "jgnep");
            Debug.Assert(ShiftMesage("helen and fernando", "a") == "helen and fernando");
            Debug.Assert(ShiftMesage("abcdef g", "bbbbb") == "bcdefg h");
        }

        public static string AskForValidInput(string word, ConsoleColor color)
        {

            while (true)
            {

                try
                {
                    ForegroundColor = DarkGray;
                    WriteLine("This program encrypts the characters of a message using the 'Vigenere' method.");
                    ForegroundColor = color;
                    Write($"Please enter the {word}: ");
                    ForegroundColor = White;
                    string message = ReadLine();
                    if (message == "")
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again with valid letters");
                        continue;
                    }
                    return message;

                }
                catch
                {
                    Clear();
                    WriteLine("That is not in the options. Try again");
                }
            }
        }
        public static char ShiftChar(char start, char shiftBy)
        {
            if (start < 'a' || start > 'z')
            {
                return start;
            }
            if (shiftBy < 'a' || shiftBy > 'z')
            {
                return start;
            }
            char shiftChar = (char)(shiftBy - 'a');
            char startChar = (char)(start - 'a');
            int intChar = (shiftChar + startChar) ;
            if (intChar > 25)
            {
                intChar -= 26;
            }
            char newChar = (char)(intChar + 'a');
            return newChar;
        }

        public static string ShiftMesage(string start, string shiftBy)
        {
            
            for (int x = 0; x < start.Length; x++)
            {
                if (start[x]>='A'||start[x]<='Z')
                {

                }
            }
            string result = "";

            for (int x = 0; x < start.Length; x++)
            {
                char shiftnewchar = ShiftChar(start[x], shiftBy[x % shiftBy.Length]);
                result += shiftnewchar;
            }
            return result;

        }
    }
}

