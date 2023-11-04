using static System.Console;

namespace MemoPad // Note: actual namespace depends on the project name.
{
    public class StudyNotes
    {
       public static void MainStudy(ref List<string> name)
        {
            List<string> notes = new List<string>();
             if (File.Exists("Notes.csv"))
            {
                string[] savednotes = File.ReadAllLines("Notes.csv");
                notes = savednotes.ToList();
            }
            while (true)
            {
            int menu = Menu(name);
            switch (menu)
            {
                case 1:
                Clear();
                    AskForNotes(notes, name);
                    break;
                case 2:
                Clear();
                    SeeNotes(notes);
                    break;
                case 3:
                Clear();
                    RemoveNotes(notes);
                    break;
            }
            if (menu == 4)
            {
                Clear();
                break;
            }
        }
  File.WriteAllLines("Notes.csv", notes);
        }

        static public void AskForNotes(List<string> notes, List<string> name)
        {


            while (true)
            {
                 string title = $"{name[0]}'s NOTES";
                 ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.White;
                for (int x = 0; x < notes.Count; x++)
                {
                    WriteLine($"{notes[x]}");
                }
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Type 'Back' to go back");
                ForegroundColor = ConsoleColor.DarkCyan;
                Write("Write something: ");
                ForegroundColor = ConsoleColor.White;
                string? usernotes = ReadLine();
                if (usernotes == "")
                {
                    Clear();
                    continue;
                }
                else if (usernotes == "Back" || usernotes == "back")
                {
                    Clear();
                    break;
                }
                else
                {
                    notes.Add(usernotes);
                    Clear();
                }
            }
        }


        public static int Menu(List <string> name)
        {
            while (true)
            {
                try
                {
                    string title = $"{name[0]}'s NOTES";
                    ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(@$"{title,50}");
                    WriteLine("1.- WRITE NOTES");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"2.- SEE NOTES");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine($"3.- DELETE NOTES");
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("4.- EXIT");
                    Console.ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the action you would like to do: ");
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3 || prompt == 4)
                        return prompt;
                    else
                    {
                        Clear();
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    WriteLine("That was not in the option. TRY AGAIN");
                }
            }
        }
        public static void SeeNotes(List<string> notes)
        {
            while (true)
            {
                string title = $"NOTES";
                ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.White;
                for (int x = 0; x < notes.Count; x++)
                {
                    WriteLine($"{notes[x]}");
                }
                Write("Press any key to go back to the menu: ");
                ReadLine();
                Clear();
                break;
            }

        }
        public static void RemoveNotes(List<string> notes)
        {
            while (true)
            {
                if (notes.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No anotations yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                    while (true)
                    {
                        try
                        {

                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine("REMOVE NOTES");
                            ForegroundColor = ConsoleColor.White;
                            WriteLine("1.-Remove ALL the notes");
                            WriteLine("2.-Remove a specific line of notes.");
                            WriteLine("3.-Back");
                            ForegroundColor = ConsoleColor.DarkGray;
                            Write("Type the number of the action you want to do: ");
                            ForegroundColor = ConsoleColor.White;
                            int choice = Convert.ToInt32(ReadLine());

                            if (choice == 1)
                            {
                                Clear();
                                notes.Clear();
                                Write("Everything is clear. Press any key to continue");
                                ReadKey();
                                Clear();
                                break;
                            }
                            if (choice == 2)
                            {

                                Clear();
                                RemoveALine(notes);
                                break;

                            }
                            if (choice == 3)
                            {
                                Clear();
                                break;
                            }

                            else
                            {
                                Clear();
                                ForegroundColor = ConsoleColor.Red;
                                WriteLine("That is not in the options. Try again");
                                continue;
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

                break;
            }
        }
        public static void RemoveALine(List<string> notes)
        {
            while (true)
            {
                string title = "REMOVE NOTES";
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"{title,50}");

                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("0.- GO BACK");
                try
                {

                    for (int x = 0; x < notes.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        WriteLine($"{x + 1}.- {notes[x]}");
                        ForegroundColor = ConsoleColor.White;
                    }
                    Write("Put the number of the activity you would like to remove: ");
                    int i = Convert.ToInt32(ReadLine());

                    if (i == 0)
                    {

                        Clear();
                        break;
                    }
                    if (i > notes.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                    }
                    else
                    {

                        Clear();
                        int remove = i - 1;
                        notes.RemoveAt(remove);

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
    }
}

    
