using System;
using static System.Console;

namespace Dictionary // Note: actual namespace depends on the project name.
{
    public class StudyDictionary
    {
        public static void MainDictionary(List<string> name)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            while (true)
            {
                int menu = Menu(name);
                switch (menu)
                {
                    case 1:
                        AddItem(dictionary);
                        Clear();
                        break;
                    case 2:
                        RemoveItem(dictionary);
                        Clear();
                        break;

                    case 3:
                    EditDefinition(ref dictionary);
                    Clear();
                    break;
                    case 4:

                        SeeCurrentDicitionary(dictionary);
                        Clear();
                        break;
                }
                if (menu == 5)
                {
                    Clear();
                    break;
                }
            }

        }
        public static void SeeCurrentDicitionary(Dictionary<string, string> dictionary)
        {
            while (true)
            {
                if (dictionary.Count != 0)
                {
                    ForegroundColor = ConsoleColor.White;
                    foreach (KeyValuePair<string, string> kvp in dictionary)
                    {
                        Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                    }
                    ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(@$"Press any key to go back to the menu");
                    ReadLine();
                    Clear();
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("NO WORDS YET");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(@$"Press any key to go back to the menu");
                    ReadLine();
                    Clear();

                    break;
                }

            }
        }
        public static int Menu(List<string> name)
        {
            while (true)
            {
                try
                {

                    string title = $"{name[0]}'s DICTIONARY";
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("1. Add new word");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. Remove words");
                     ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("3. Edit definition");
                     ForegroundColor = ConsoleColor.Green;
                    WriteLine("4. See current dictionary");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("5. Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Type the number of the action you want to do: ");
                    ForegroundColor = ConsoleColor.White;
                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4||choice == 5)
                    {
                        Clear();
                        return choice;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not in the options. Try again");
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not in the options. Try again");
                }
            }
        }

        static void AddItem(Dictionary<string, string> dictionary)
        {

            while (true)
            {
                string title = "ADD TO DICITONARY";
                ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@$"Type 'Back' to go back to the menu");
                ForegroundColor = ConsoleColor.White;
                if (dictionary.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO DEFINITIONS YET");
                    ForegroundColor = ConsoleColor.DarkGray;
                    foreach (KeyValuePair<string, string> kvp in dictionary)
                    {
                        Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);

                    }
                }
                else
                {
                    foreach (KeyValuePair<string, string> kvp in dictionary)
                    {
                        Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);

                    }
                }

                ForegroundColor = ConsoleColor.Magenta;
                Write("Add new word: ");
                ForegroundColor = ConsoleColor.White;
                string? userword = ReadLine();
                if (userword != "" && userword != "Back" && userword != "back")
                {
                    Clear();
                    string title2 = "ADD TO DICITONARY";
                    ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"{title2,50}");
                    ForegroundColor = ConsoleColor.Green;
                    Write($"Word: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{userword}");
                    Write("Add its definition: ");
                    string? definition = ReadLine();
                    if (definition != "")
                    {
                        dictionary.Add(userword, definition);
                        Clear();
                        continue;
                    }
                    else if (definition == "")
                    {
                        Clear();
                        WriteLine("You must write something as a defintion");
                        continue;
                    }
                }
                else if (userword == "")
                {
                    Clear();
                    continue;
                }
                else
                {
                    Clear();
                    break;
                }
            }
        }
        static void EditDefinition(ref Dictionary<string, string> dictionary)
        {
            while (true)
            {
                foreach (KeyValuePair<string, string> kvp in dictionary)
                {
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            
            ForegroundColor = ConsoleColor.DarkGray;
              WriteLine("Type Back to go back to the menu. ");
               ForegroundColor = ConsoleColor.Yellow;
            Write("Type the word  that contains the definition you want to change: ");
            ForegroundColor = ConsoleColor.White;
            string? edit = ReadLine();
            if (edit != "" && edit != "Back" && edit != "back")
            {
                if (dictionary.ContainsKey(edit))
                {
                    Clear();
                    WriteLine($"New definition:");
                    ForegroundColor = ConsoleColor.Green;
                     Write($"{edit}: ");
            ForegroundColor = ConsoleColor.White;
            string? name = ReadLine();
            dictionary[edit]=name;
        
            Clear();
                    continue;
                }
                else
                {
                    Clear();
                    WriteLine("That word does not exist in the dicttionary");
                    continue;
                }
            }
            else if (edit == "")
            {
                Clear();
                continue;
            }
            else
            {
                break;
            }
        }
    }
    static void RemoveItem(Dictionary<string, string> dictionary)
    {
        while (true)
        {
            string title = "REMOVE A WORD";
            ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@$"{title,50}");
            ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@$"Type the name of the word you would like to remove,its definition will be removed to. Type 'Back' to go back to the menu");
            ForegroundColor = ConsoleColor.White;
            if (dictionary.Count == 0)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO DEFINITIONS YET");
                ReadKey();
                break;
            }
            else
            {
                foreach (KeyValuePair<string, string> kvp in dictionary)
                {
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
            ForegroundColor = ConsoleColor.Red;
            Write("Remove word: ");
            ForegroundColor = ConsoleColor.White;
            string? remove = ReadLine();
            if (remove != "" && remove != "Back" && remove != "back")
            {
                if (dictionary.ContainsKey(remove))
                {
                    Clear();
                    dictionary.Remove(remove);
                    continue;
                }
                else
                {
                    Clear();
                    WriteLine("That word does not exist in the dicttionary");
                    continue;
                }
            }
            else if (remove == "")
            {
                Clear();
                continue;
            }
            else
            {
                break;
            }

        }
    }

}
}