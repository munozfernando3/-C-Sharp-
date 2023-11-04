using System;
using static System.Console;
namespace ClassSchedule
{
    public class Schedule
    {
        public static void MainSchedule()
        {
            List<string> classes = new List<string>();
            List<string> days = new List<string>();
            List<string> time = new List<string>();
            List<string> time2 = new List<string>();
            if (File.Exists("SavedSchedule\\Classes.csv"))
            {
                string[] savedclasses = File.ReadAllLines("SavedSchedule\\Classes.csv");
                classes = savedclasses.ToList();
            }
            if (File.Exists("SavedSchedule\\Days.csv"))
            {
                string[] saveddays = File.ReadAllLines("SavedSchedule\\Days.csv");
                days = saveddays.ToList();
            }
            if (File.Exists("SavedSchedule\\StartingTime.csv"))
            {
                string[] startingtime = File.ReadAllLines("SavedSchedule\\StartingTime.csv");
                time = startingtime.ToList();
            }
            if (File.Exists("SavedSchedule\\FinishingTime.csv"))
            {
                string[] finishtime = File.ReadAllLines("SavedSchedule\\FinishingTime.csv");
                time2 = finishtime.ToList();
            }


            while (true)
            {
                int menu = Menu();
                switch (menu)
                {
                    case 1:
                        SeeCurrentSchedule(classes, days, time, time2);
                        break;
                    case 2:
                        AddAClass(classes, days, time, time2);
                        break;
                    case 3:
                        RemoveAClass(classes, days, time, time2);
                        break;
                }
                if (menu == 4)
                {
                    break;
                }
            }
            Directory.CreateDirectory("SavedSchedule");

            File.WriteAllLines("SavedSchedule\\Classes.csv", classes);
            File.WriteAllLines("SavedSchedule\\Days.csv", days);
            File.WriteAllLines("SavedSchedule\\StartingTime.csv", time);
            File.WriteAllLines("SavedSchedule\\FinishingTime.csv", time2);
        }
        public static void RemoveAClass(List<string> classes, List<string> days, List<string> time, List<string> time2)
        {
            while (true)
            {
                if (classes.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No classes yet");
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
                            WriteLine("REMOVE CLASSES");
                            ForegroundColor = ConsoleColor.White;
                            WriteLine("1.-Remove ALL the schedule");
                            WriteLine("2.-Remove a specific class.");
                            WriteLine("3.-Back");
                            ForegroundColor = ConsoleColor.DarkGray;
                            Write("Type the number of the action you want to do: ");
                            ForegroundColor = ConsoleColor.White;
                            int choice = Convert.ToInt32(ReadLine());

                            if (choice == 1)
                            {
                                Clear();
                                classes.Clear();
                                days.Clear();
                                time.Clear();
                                time2.Clear();
                                WriteLine("Everything is clear. Press any key to continue");
                                ReadKey();
                                break;
                            }
                            else if (choice == 2)
                            {
                                Clear();
                                RemoveASpecificClass(classes, days, time, time2);
                            }
                            else if (choice == 3)
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

        public static void RemoveASpecificClass(List<string> classes, List<string> days, List<string> time, List<string> time2)
        {
            while (true)
            {
                try
                {
                    WriteLine("0. Back");
                    DisplaySchedule(classes, days, time, time2);
                    Write("Put the number of the activity you would like to remove: ");
                    int i = Convert.ToInt32(ReadLine());

                    if (i == 0)
                    {

                        Clear();
                        break;
                    }
                    if (i > classes.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                    }
                    else
                    {
                        Clear();
                        classes.RemoveAt(i - 1);
                        days.RemoveAt(i - 1);
                        time.RemoveAt(i - 1);
                        time2.RemoveAt(i - 1);
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

        public static void DisplaySchedule(List<string> classes, List<string> days, List<string> time, List<string> time2)
        {
            ForegroundColor = ConsoleColor.Yellow;
            Write("Class");
            ForegroundColor = ConsoleColor.Green;
            Write($"{"Day",33}");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine($"{"Time",30}");
            ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < classes.Count; x++)
            {
                for (int i = x; i < days.Count;)
                {
                    for (int y = i; y < time.Count;)
                    {
                        for (int a = y; a < time2.Count;)
                        {
                            WriteLine($"{x + 1}. {classes[x],-30} {days[i],-26} {time[y]} - {time2[a]}");
                            break;
                        }
                        break;
                    }
                    break;
                }

            }
            WriteLine("---------------------------------------------------------------------------------");
        }
       
        static int Menu()
        {
            while (true)
            {
                try
                {

                    string title = "CLASS SCHEDULE MENU";
                    ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("1. See current schedule");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. Add Classes");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("3. Remove a Class");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("4. Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Type the number of the action you want to do: ");
                    ForegroundColor = ConsoleColor.White;
                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
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

        public static void SeeCurrentSchedule(List<string> classes, List<string> days, List<string> time, List<string> time2)
        {
            while (true)
            {

                if (classes.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No classes yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                    DisplaySchedule(classes, days, time, time2);
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
            }
        }
        
        public static void AddAClass(List<string> classes, List<string> days, List<string> time, List<string> time2)

        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.White;
                    string title = "ADD A CLASS";
                    ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(@$"Type 'Back' to go back to the menu");
                    ForegroundColor = ConsoleColor.White;
                    if (classes.Count == 0)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO CLASSES YET");
                        ForegroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        DisplaySchedule(classes, days, time, time2);
                    }
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Add all your classes in order of time and day, to create a more organized and truthful schedule");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("Add new class: ");
                    ForegroundColor = ConsoleColor.White;
                    string? userclass = ReadLine();
                    if (userclass != "" && userclass != "Back" && userclass != "back")
                    {
                        classes.Add(userclass);
                        Clear();
                        int Day = AskForDay(userclass);
                        AddDays(Day, ref days);

                        int hour = AskForStartingHour(userclass);
                        Clear();
                        int minutes = AskForStartingMinutes(userclass);
                        Clear();
                        int hour2 = AskForFinishHour(userclass);
                        Clear();
                        int minutes2 = AskForFinishingMinutes(userclass);
                        Clear();
                        if (minutes < 10)
                        {
                            var Time = new TimeOnly(hour, minutes);
                            string startingtime = $"{hour}:0{minutes}";
                            time.Add(startingtime);

                        }
                        else
                        {
                            var Time = new TimeOnly(hour, minutes);
                            string startingtime = $"{hour}:{minutes}";
                            time.Add(startingtime);
                        }
                        if (minutes2 < 10)
                        {
                            string finishtime = $"{hour2}:0{minutes2}";
                            time2.Add(finishtime);
                        }
                        else
                        {
                            string finishtime = $"{hour2}:{minutes2}";
                            time2.Add(finishtime);
                        }
                    }
                    else if (userclass == "")
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


                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not in the options. Try again");

                }
            }
        }
        
        public static int AskForDay(string userclass)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("DAYS");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("1. Monday");
                    WriteLine("2. Tuesday");
                    WriteLine("3. Wednesday");
                    WriteLine("4. Thursday");
                    WriteLine("5. Friday");
                    WriteLine("6. Saturday ");
                    WriteLine("7. Sunday ");
                    WriteLine($"Put the number of the day you have {userclass}: ");
                    ForegroundColor = ConsoleColor.Blue;
                    Write($"Number of day: ");
                    ForegroundColor = ConsoleColor.White;
                    int day = Convert.ToInt32(ReadLine());
                    if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5 || day == 6 || day == 7)

                    {
                        Clear();
                        return day;
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
        
        public static void AddDays(int Day, ref List<string> days)
        {
            if (Day == 1)
            {
                days.Add("Monday");
            }
            else if (Day == 2)
            {
                days.Add("Tuesday");
            }
            else if (Day == 3)
            {
                days.Add("Wednesday");
            }
            else if (Day == 4)
            {
                days.Add("Thursday");
            }
            else if (Day == 5)
            {
                days.Add("Friday");
            }
            else if (Day == 6)
            {
                days.Add("Saturday");
            }
            else if (Day == 7)
            {
                days.Add("Sunday");
            }
        }
        
        public static int AskForStartingHour(string Class)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Green;
                    Write("Class: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{Class}");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Starting Time");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Use natural numbers, bewteen (0-23) to set the hour. No need to write pm or am");
                    ForegroundColor = ConsoleColor.Magenta;
                    Write("Hour: ");
                    ForegroundColor = ConsoleColor.White;
                    int hour = Convert.ToInt32(ReadLine());
                    if (hour < 24 && hour >= 0)
                    {
                        return hour;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
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
        
        public static int AskForFinishHour(string Class)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Green;
                    Write("Class: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{Class}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Finishing Time");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Use natural numbers, bewteen (0-23) to set the hour. No need to write pm or am");
                    ForegroundColor = ConsoleColor.Magenta;
                    Write("Hour: ");
                    ForegroundColor = ConsoleColor.White;
                    int hour = Convert.ToInt32(ReadLine());
                    if (hour < 24 && hour >= 0)
                    {
                        return hour;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
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
       
        public static int AskForStartingMinutes(string Class)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Magenta;
                    Write("Classs: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{Class}");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Starting Time");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Use natural numbers, bewteen (0-59) to set the minutes");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("Minutes: ");
                    ForegroundColor = ConsoleColor.White;
                    int minutes = Convert.ToInt32(ReadLine());
                    if (minutes < 60 && minutes >= 0)
                    {
                        return minutes;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. Try again");
                }

            }

        }
        
        public static int AskForFinishingMinutes(string Class)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Green;
                    Write("Classs: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{Class}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Finishing Time");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Use natural numbers, bewteen (0-59) to set the minutes");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("Minutes: ");
                    ForegroundColor = ConsoleColor.White;
                    int minutes = Convert.ToInt32(ReadLine());
                    if (minutes < 60 && minutes >= 0)
                    {
                        return minutes;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. Try again");
                }

            }

        }
    }
}
