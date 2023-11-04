using System;
using static System.Console;
using static System.ConsoleColor;
using ToDoList;
using GPACalculator;
using Dictionary;
using ClassSchedule;
using Trivia;
using MathConverter;
using MemoPad;
using Reminder;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            List<string> name = new List<string>();
            List<DateTime> REMINDER = new List<DateTime>();
            List<string> nameEvent = new List<string>();

            if (File.Exists("Name.csv"))
            {
                string[] namesaved = File.ReadAllLines("Name.csv");
                name = namesaved.ToList();
            }
            else
            {
                Clear();
                Intro(name);
            }
            while (true)
            {


                int menu = Menu(now, ref name, REMINDER, nameEvent);
                switch (menu)
                {
                    case 1:
                        Clear();
                        ToDo.MainList(ref name);
                        break;
                    case 2:
                        Clear();
                        Schedule.MainSchedule();
                        break;
                    case 3:
                        Clear();
                        StudyNotes.MainStudy(ref name);
                        break;
                    case 4:
                        Clear();
                        StudyDictionary.MainDictionary(name);
                        break;
                    case 5:
                        Clear();
                        GPACALCULATOR.MainGPACalculator();
                        break;
                    case 6:
                        Clear();
                        Quizz.MainTrivia();
                        break;
                    case 8:
                        Clear();
                        SetAReminder.MainReminder(ref REMINDER, ref nameEvent);
                        break;
                    case 7:
                        Clear();
                        DisplaySettings(ref name);
                        break;
                }
                if (menu == 9)
                {
                    Clear();
                    break;
                }
            }

            File.WriteAllLines("Name.csv", name);

        }

        public static void Intro(List<string> name)
        {
            while (true)
            {
                try
                {
                    const string title = $"MY BADGER APP";
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@$"{title,60}");
                    ForegroundColor = White;
                    Write("Enter your name: ");
                    string? names = ReadLine();
                    if (names == "")
                    {
                        Clear();
                        continue;
                    }
                    else
                    {
                        Clear();
                        name.Add(names);
                        break;
                    }
                }
                catch
                {
                    ForegroundColor = Red;
                    Clear();
                    WriteLine("Please, do not use numbers for your name");
                    WriteLine("Try again");

                }

            }
        }
        static int Menu(DateTime now, ref List<string> name, List<DateTime> REMINDER, List<string> nameevent)
        {
            while (true)
            {
                try
                {

                    Clear();
                    string[] greetings = new string[] { $"It is good to see you {name[0]}.", "How is it going?", "Hello, lovely user.", "Hello, there.", $"Hey, {name[0]}, how are things?", $"What's up, {name[0]}?", "How's everything going?", "Salut!", $"Hey {name[0]}, how are you?", $"Hello {name[0]}, have a wonderful day!!!, HAPPY NEW YEAR!!!1" };
                    if (now == new DateTime(2023, 1, 1))
                    {
                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine($"{greetings[10]}");
                    }

                    {
                        Random random = new Random();
                        ForegroundColor = ConsoleColor.Gray;
                        string randomgreeting = greetings[random.Next(greetings.Length - 1)];
                        WriteLine($"{randomgreeting}");
                    }
                    string reminder = ReminderActivities();
                    if (reminder == "NO EVENTS FOR TODAY")
                    {
                        ForegroundColor = ConsoleColor.Magenta;
                        Write("Snow Reminder: ");
                        ForegroundColor = ConsoleColor.DarkGray;
                        WriteLine($"{reminder}");
                        WriteLine("-----------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Snow Reminder: ");
                        ForegroundColor = ConsoleColor.White;
                        WriteLine($"{reminder}");
                        WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }


                    if (nameevent.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        WriteLine("Todays Reminders: ");
                        for (int x = 0; x < REMINDER.Count; x++)
                        {
                            for (int y = x; y < nameevent.Count;)
                            {
                                if (REMINDER[x] == DateTime.Today)
                                {
                                    ;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    WriteLine($"{x + 1}.- {nameevent[y]}");
                                }

                                break;
                            }

                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Write("Today Reminder: ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        WriteLine("NO EVENTS FOR TODAY");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(@$"{"MY BADGER APP",60}");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("1.- TO DO LIST");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"2.- CLASS SCHEDULE");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine($"3.- NOTES");
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("4.- STUDY DICTIONARY");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine("5.- GPA CALCULATOR");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("6.- TRIVIA");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("7.- SETTINGS");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    WriteLine("8.- SET A REMINDER");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("9.- EXIT");
                    Console.ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the action you would like to do: ");
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3 || prompt == 4 || prompt == 5 || prompt == 6 || prompt == 7 || prompt == 8 || prompt == 9)
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
        public static void ResetAllInformation()
        {
            while (true)
            {
                Write("Everything is reset. Press any key to go back: ");
                if (Directory.Exists("SavedActivities"))
                {
                    Directory.Delete("SavedActivities");

                }
                if (Directory.Exists("Scores"))
                {
                    Directory.Delete("Scores");
                }
                if (Directory.Exists("SavedSchedule"))
                {
                    Directory.Delete("SavedSchedule");
                }
                ReadKey();
                break;

            }
        }
        public static void ResetScores()
        {
            while (true)
            {
                Write("The scores were reset. Press any key to go back: ");

                if (Directory.Exists("SavedActivities"))
                {
                    Directory.Delete("SavedActivities");

                }
                ReadKey();
                break;

            }
        }
        public static void ResetActivities()
        {
            while (true)
            {
                Write("The activities were reset. Press any key to go back: ");

                if (Directory.Exists("Scores"))
                {
                    Directory.Delete("Scores");
                }
                ReadKey();
                break;

            }
        }
        public static void ChangeName(ref List<string> name)
        {
            while (true)
            {
                Write("Change current Name: ");
                string? username = ReadLine();
                if (username == "")
                {
                    Clear();
                    continue;
                }
                else
                {
                    Clear();
                    name.Clear();
                    name.Add(username);
                    break;
                }
            }
        }
        public static string ReminderActivities()
        {
            DateTime currentdate = DateTime.Today;
            DateTime honorsprogram = new DateTime(2022, 12, 7);
            DateTime christmasGoodie = new DateTime(2022, 12, 8);
            DateTime falldance = new DateTime(2022, 12, 9);
            DateTime christmasboutique = new DateTime(2022, 12, 10);
            DateTime foundationsfair = new DateTime(2022, 12, 12);
            DateTime FINALS = new DateTime(2022, 12, 16);

            if (currentdate == honorsprogram)
            {
                string Event = "1.- Honors Program Event. GSC 16:00-18:00.\n2.- Trent Hanna Concert. Eccles 19:30-20:30.\n3.- Retro Prom/Dance. GSC 21:00-23:00";
                return Event;
            }
            else if (currentdate == christmasGoodie)
            {
                string Event = "Chirstmas Goodie Bag Event. Castilleja 18:00-20:00";
                return Event;
            }
            else if (currentdate == falldance)
            {
                string Event = "Fall Dance Concert. Eccles 18:30-21:30";
                return Event;
            }
            else if (currentdate == christmasboutique)
            {
                string Event = "Christmas Boutique for Charity. Wild Acress Barn 11:00-16:00";
                return Event;
            }
            else if (currentdate == foundationsfair)
            {
                string Event = "Foundations Fair. GSC 11:30-18:00";
                return Event;
            }
            else if (currentdate == FINALS)
            {
                string Event = "FINAL DAY OF CLASSES!!";
                return Event;
            }

            else
            {
                string nothing = "NO EVENTS FOR TODAY";
                return nothing;

            }
        }
        public static int Settings()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(@$"{"SETTINGS",60}");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("1.- Change Name");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"2.- Reset Trivia Scores");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine($"3.- Reset To-Do List");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    WriteLine("4.- Reset EVERYTHING");
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("5.- Back");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Write("Put the number of the action you would like to do: ");
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3 || prompt == 4 || prompt == 5)
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
        public static void DisplaySettings(ref List<string> name)
        {
            while (true)
            {


                int menu = Settings();
                switch (menu)
                {
                    case 1:
                        Clear();
                        ChangeName(ref name);
                        break;
                    case 2:
                        Clear();
                        ResetScores();
                        break;
                    case 3:
                        Clear();
                        ResetActivities();
                        break;
                    case 4:
                        Clear();
                        ResetAllInformation();
                        break;

                }
                if (menu == 5)
                {
                    Clear();
                    break;

                }
            }
        }
       
    }
}