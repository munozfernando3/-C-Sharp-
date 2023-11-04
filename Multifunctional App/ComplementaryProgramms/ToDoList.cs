using System;
using static System.Console;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    public class ToDo
    {
        public static void MainList(ref List<string> name)
        {

            List<string> totalactivities = new List<string>();
            List<string> activities = new List<string>();
            List<DateTime> initialtime = new List<DateTime>();
            List<string> StartedActivities = new List<string>();
            List<string> StartedActivitiesRemaining = new List<string>();
            List<DateTime> completedtime = new List<DateTime>();
            List<string> CompletedActivities = new List<string>();
            List<TimeSpan> averagetime = new List<TimeSpan>();
            List<string> stats = new List<string>();
            List<int> activitiesbyday = new List<int>(totalactivities.Count);
            List<string> status = new List<string>();
            int incomplete;
            int inprogress;
            double averageseconds = 0;
            TimeSpan averagedate;
            if (File.Exists("SavedActivities\\TotalActivities.csv"))
            {
                string[] savedactivities = File.ReadAllLines("SavedActivities\\TotalActivities.csv");
                totalactivities = savedactivities.ToList();
            }
            if (File.Exists("Stats.csv"))
            {
                string[] statssaved = File.ReadAllLines("Stats.csv");
                stats = statssaved.ToList();
            }
            if (File.Exists("SavedActivities\\Activities.csv"))
            {
                string[] activitiessaved = File.ReadAllLines("SavedActivities\\Activities.csv");
                activities = activitiessaved.ToList();
            }
            if (File.Exists("SavedActivities\\StartedActivities.csv"))
            {
                string[] startedactivitiessaved = File.ReadAllLines("SavedActivities\\StartedActivities.csv");
                StartedActivities = startedactivitiessaved.ToList();
            }
            if (File.Exists("SavedActivities\\CompletedActivities.csv"))
            {
                string[] completedactivitiessaved = File.ReadAllLines("SavedActivities\\CompletedActivities.csv");
                CompletedActivities = completedactivitiessaved.ToList();
            }
            if (File.Exists("SavedActivities\\StartedActivities2.csv"))
            {
                string[] startedactivitiessaved2 = File.ReadAllLines("SavedActivities\\StartedActivities2.csv");
                StartedActivitiesRemaining = startedactivitiessaved2.ToList();
            }
            if (File.Exists("SavedActivities\\Status.csv"))
            {
                string[] statusarray = File.ReadAllLines("SavedActivities\\Status.csv");
                status = statusarray.ToList();
            }
  
            while (true)
            {
                int menu = Menu(ref name);
                switch (menu)
                {
                    case 1:
                        SeeCurrentList(totalactivities, activities, StartedActivities, CompletedActivities, status);
                        break;
                    case 2:
                        AddToDoList(totalactivities, activities, status);
                        break;
                    case 3:
                        StartActivity(totalactivities, activities, StartedActivities, StartedActivitiesRemaining, initialtime, ref status);
                        break;
                    case 4:
                        CompleteActivity(totalactivities, StartedActivities, CompletedActivities, completedtime, ref status);
                        break;
                    case 5:
                        RemoveActivity(totalactivities, activities, StartedActivities, CompletedActivities, StartedActivitiesRemaining, ref status);
                        break;
                    case 6:
                        StatsCalc(totalactivities, StartedActivities, StartedActivitiesRemaining, CompletedActivities, initialtime, completedtime, averagetime, out averagedate, activitiesbyday, ref averageseconds, out incomplete, out inprogress);
                        StatsView(totalactivities, StartedActivities, CompletedActivities, initialtime, completedtime, averagetime, stats, ref averagedate, activitiesbyday, ref averageseconds, ref incomplete, ref inprogress);

                        break;
                }
                if (menu == 7)
                {
                    break;
                }
            }
            Directory.CreateDirectory("SavedActivities");
            File.WriteAllLines("SavedActivities\\TotalActivities.csv", totalactivities);
            File.WriteAllLines("SavedActivities\\Stats.csv", stats);
            File.WriteAllLines("SavedActivities\\Activities.csv", activities);
            File.WriteAllLines("SavedActivities\\StartedActivities.csv", StartedActivities);
            File.WriteAllLines("SavedActivities\\CompletedActivities.csv", CompletedActivities);
            File.WriteAllLines("SavedActivities\\StartedActivities2.csv", StartedActivitiesRemaining);
            File.WriteAllLines("SavedActivities\\Status.csv", status);
                     
            
            

        }
        static int Menu(ref List<string> name)
        {
            while (true)
            {
                try
                {

                    string title = $"{name[0]}'s TO DO LIST MENU";
                    ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("1. See current List");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. Add activities");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("3. Start an activity.");
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("4. Complete an activity");
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("5. Remove an activity");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("6. See statitics");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("7. Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Type the number of the action you want to do: ");
                    ForegroundColor = ConsoleColor.White;
                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 || choice == 7)
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

        static void AddToDoList(List<string> totalactivities, List<string> activities, List<string> status)
        {

            while (true)
            {
                string title = "TO DO LIST";
                ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@$"Type 'Back' to go back to the menu");
                ForegroundColor = ConsoleColor.White;
                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO ACTIVITIES YET");
                }
                else
                {
                    for (int x = 0; x < totalactivities.Count; x++)
                    {
                        for (int y = x; y < status.Count;)
                        {
                            ForegroundColor = ConsoleColor.White;
                            Write($"{x + 1}.- {totalactivities[x],-30}");
                            ForegroundColor = ConsoleColor.Gray;
                            WriteLine($"{status[y]}");
                            break;
                        }

                    }

                }

                ForegroundColor = ConsoleColor.Blue;
                Write("Add new activity: ");
                ForegroundColor = ConsoleColor.White;
                string? useractivities = ReadLine();
                if (useractivities != "" && useractivities != "Back" && useractivities != "back")
                {
                    totalactivities.Add(useractivities);
                    activities.Add(useractivities);
                    status.Add("Incomplete");
                    Clear();
                }
                else if (useractivities == "")
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
        static void AddToDoListSaved(List<string> totalactivities, List<string> activities, string[] savedactivities)
        {

            while (true)
            {
                totalactivities = savedactivities.ToList();
                string title = "TO DO LIST";
                ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@$"Type 'Back' to go back to the menu");
                ForegroundColor = ConsoleColor.White;
                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO ACTIVITIES YET");
                }
                else
                {
                    for (int x = 0; x < totalactivities.Count; x++)
                    {
                        WriteLine($"{x + 1}.- {totalactivities[x]}");
                    }

                }

                ForegroundColor = ConsoleColor.Blue;
                Write("Add new activity: ");
                ForegroundColor = ConsoleColor.White;
                string? useractivities = ReadLine();
                if (useractivities != "" && useractivities != "Back" && useractivities != "back")
                {
                    totalactivities.Add(useractivities);
                    activities.Add(useractivities);
                    Clear();
                }
                else if (useractivities == "")
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
        public static void StartActivity(List<string> totalactivities, List<string> activities, List<string> StartedActivities, List<string> StartedActivitiesRemaining, List<DateTime> initialtime, ref List<string> status)
        {
            while (true)
            {
                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No activities yet");
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
                        AskforActivityStarting(totalactivities, activities, StartedActivities, StartedActivitiesRemaining, initialtime, ref status);
                        break;
                    }
                    break;
                }



            }
        }
        public static void AskforActivityStarting(List<string> totalactivities, List<string> activities, List<string> StartedActivities, List<string> StartedActivitiesRemaining, List<DateTime> initialtime, ref List<string> status)
        {

            while (true)
            {
                string title = "CURRENT ACTIVITIES";
                ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("0.- GO BACK");
                try
                {
                    for (int x = 0; x < activities.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        WriteLine($"{x + 1}.- {activities[x]}");
                    }
                    ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the activity you would like to start: ");
                    int i = Convert.ToInt32(ReadLine());
                    if (i == 0)
                    {
                        Clear();
                        break;
                    }
                    if (i > activities.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }

                    else
                    {
                        Clear();
                        for (int x = i - 1; x < activities.Count;)
                        {
                            string nameofactivity = activities[x];
                            int index = totalactivities.IndexOf(nameofactivity);
                            status[index] = "In Progress...";
                            StartedActivities.Add(activities[x]);
                            StartedActivitiesRemaining.Add(activities[x]);
                            activities.RemoveAt(i - 1);
                            initialtime.Add(DateTime.Now);
                            break;
                        }
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. Try again");
                    continue;
                }
            }
        }
        static void CompleteActivity(List<string> totalactivities, List<string> StartedActivities, List<string> CompletedActivities, List<DateTime> completedTime, ref List<string> status)
        {
            while (true)
            {
                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.White;
                    string title = "STARTED ACTIVITIES";
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No activities yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                if (StartedActivities.Count == 0 && totalactivities.Count > 0)
                {
                    ForegroundColor = ConsoleColor.White;
                    string title = "STARTED ACTIVITIES";
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("You have not started an activity yet. Go back to the menu to start an activity.");
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
                        AskForActivityCompleting(totalactivities, StartedActivities, CompletedActivities, completedTime, ref status);
                        break;
                    }
                    break;

                }
            }
        }
        static void AskForActivityCompleting(List<string> totalactivities, List<string> StartedActivities, List<string> CompletedActivities, List<DateTime> completedTime, ref List<string> status)
        {
            while (true)
            {
                string title = "STARTED ACTIVITIES";
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("0.- GO BACK");
                try
                {
                    for (int x = 0; x < StartedActivities.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        WriteLine($"{x + 1}.- {StartedActivities[x]}");
                    }
                    ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the activity you would like to complete: ");
                    int i = Convert.ToInt32(ReadLine());
                    if (i == 0)
                    {
                        Clear();
                        break;
                    }
                    if (i > StartedActivities.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }
                    else
                    {

                        Clear();
                        for (int x = i - 1; x < StartedActivities.Count;)
                        {
                            string nameofactivity = StartedActivities[x];
                            int index = totalactivities.IndexOf(nameofactivity);
                            status[index] = "Completed";
                            CompletedActivities.Add(StartedActivities[x]);
                            completedTime.Add(DateTime.Now);
                            StartedActivities.RemoveAt(i - 1);
                            break;
                        }
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. Try again");
                    continue;
                }
            }
        }
        public static void RemoveActivity(List<string> totalactivities, List<string> activities, List<string> StartedActivities, List<string> CompletedActivities, List<string> StartedActivitiesRemaining, ref List<string> status)
        {
            while (true)
            {
                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No activities yet");
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
                            WriteLine("REMOVE ACTIVITIES");
                            ForegroundColor = ConsoleColor.White;
                            WriteLine("1.-Remove ALL the activities");
                            WriteLine("2.-Remove a specific activity.");
                            WriteLine("3.-Back");
                            ForegroundColor = ConsoleColor.DarkGray;
                            Write("Type the number of the action you want to do: ");
                            ForegroundColor = ConsoleColor.White;
                            int choice = Convert.ToInt32(ReadLine());

                            if (choice == 1)
                            {
                                Clear();
                                totalactivities.Clear();
                                activities.Clear();
                                StartedActivities.Clear();
                                CompletedActivities.Clear();
                                StartedActivitiesRemaining.Clear();
                                status.Clear();
                                WriteLine("Everything is clear. Press any key to continue");
                                ReadKey();
                                break;
                            }
                            if (choice == 2)
                            {

                                Clear();
                                RemoveActivities(totalactivities, activities, StartedActivities, CompletedActivities, StartedActivitiesRemaining, ref status);
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


        public static void RemoveActivities(List<string> totalactivities, List<string> activities, List<string> StartedActivities, List<string> CompletedActivities, List<string> StartedActivitiesRemaining, ref List<string> status)
        {
            while (true)
            {
                string title = "REMOVE ACTIVITIES";
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"{title,50}");

                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("0.- GO BACK");
                try
                {

                    for (int x = 0; x < totalactivities.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        WriteLine($"{x + 1}.- {totalactivities[x]}");
                        ForegroundColor = ConsoleColor.White;
                    }
                    Write("Put the number of the activity you would like to remove: ");
                    int i = Convert.ToInt32(ReadLine());

                    if (i == 0)
                    {

                        Clear();
                        break;
                    }
                    if (i > totalactivities.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                    }
                    else
                    {

                        Clear();
                        int remove = i - 1;
                        string nameofactivity = totalactivities[remove];
                        bool IfContains = StartedActivities.Contains(nameofactivity);
                        bool IfContains2 = activities.Contains(nameofactivity);
                        bool IfContains3 = CompletedActivities.Contains(nameofactivity);
                        bool IfContains4 = StartedActivitiesRemaining.Contains(nameofactivity);
                        totalactivities.RemoveAt(remove);
                        status.RemoveAt(remove);
                        if (IfContains == true)
                        {
                            int index = StartedActivities.IndexOf(nameofactivity);
                            StartedActivities.RemoveAt(index);
                        }
                        if (IfContains2 == true)
                        {
                            int index2 = activities.IndexOf(nameofactivity);
                            activities.RemoveAt(index2);
                        }
                        if (IfContains3 == true)
                        {
                            int index3 = CompletedActivities.IndexOf(nameofactivity);
                            CompletedActivities.RemoveAt(index3);
                        }
                        if (IfContains4 == true)
                        {
                            int index4 = StartedActivitiesRemaining.IndexOf(nameofactivity);
                            StartedActivitiesRemaining.RemoveAt(index4);
                        }

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

        public static void SeeCurrentList(List<string> totalactivities, List<string> activities, List<string> startedactivities, List<string> completedactivities, List<string> status)
        {
            while (true)
            {

                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No activities yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                    int choice = SeeListMenu();
                    switch (choice)
                    {
                        case 1:
                            SeeTotalList(totalactivities, status);
                            break;
                        case 2:
                            SeeInprogressActivities(startedactivities);
                            break;
                        case 3:
                            SeeCompletedActivities(completedactivities);
                            break;
                        case 4:
                            SeeMissingActivities(activities);
                            break;
                    }
                    if (choice == 5)
                    {
                        Clear();
                        break;
                    }

                }
            }
        }
        public static void SeeTotalList(List<string> totalactivities, List<string> status)
        {
            while (true)
            {

                if (totalactivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No activities yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("TOTAL ACTIVITIES");
                    ForegroundColor = ConsoleColor.White;
                    for (int x = 0; x < totalactivities.Count; x++)
                    {
                        for (int y = x; y < status.Count;)
                        {
                            Write($"{x + 1}.- {totalactivities[x],-30}");
                            ForegroundColor = ConsoleColor.Gray;
                            WriteLine($"{status[y]}");
                            break;
                        }

                    }
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
            }
        }
        public static void SeeInprogressActivities(List<string> StartedActivities)
        {
            while (true)
            {

                if (StartedActivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No started activities yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                    for (int x = 0; x < StartedActivities.Count; x++)
                    {
                        WriteLine($"{x + 1}.- {StartedActivities[x]}");
                    }
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
            }
        }
        public static void SeeCompletedActivities(List<string> CompletedActivities)
        {
            while (true)
            {

                if (CompletedActivities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No completed activities yet");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                    for (int x = 0; x < CompletedActivities.Count; x++)
                    {
                        WriteLine($"{x + 1}.- {CompletedActivities[x]}");
                    }
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
            }
        }
        public static void SeeMissingActivities(List<string> activities)
        {
            while (true)
            {

                if (activities.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("No missing activities, CONGRATS!");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
                else
                {
                       ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("MISSING ACTIVITES");
                      ForegroundColor = ConsoleColor.White;
                    for (int x = 0; x < activities.Count; x++)
                    {
                        WriteLine($"{x + 1}.- {activities[x]}");
                    }
                      ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press any key to go back: ");
                    ReadKey();
                    Clear();
                    break;
                }
            }
        }
        static int SeeListMenu()
        {
            while (true)
            {
                try
                {

                    string title = "SEE CURRENT LIST";
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("1. See total activities");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. See in-progress activities");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("3. See completed activities.");
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("4. See missing activities");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("5. Back");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Type the number of the action you want to do: ");
                    ForegroundColor = ConsoleColor.White;
                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
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
        public static void StatsCalc(List<string> totalactivities, List<string> StartedActivities, List<string> StartedActivitiesRemaining, List<string> CompletedActivities, List<DateTime> initialtime, List<DateTime> completedtime, List<TimeSpan> averagetime, out TimeSpan averagedate, List<int> activitiesperday, ref double averageseconds, out int incomplete, out int inprogress)
        {
            incomplete = totalactivities.Count - StartedActivitiesRemaining.Count;
            inprogress = StartedActivities.Count;
            for (int y = 0; y < completedtime.Count; y++)
            {
                TimeSpan average = completedtime[y] - initialtime[y];
                averagetime.Add(average);
            }

            for (int i = 0; i < averagetime.Count; i++)
            {
                double totalseconds = +averagetime[i].TotalSeconds + 0;
                averageseconds = totalseconds / averagetime.Count;
            }
            averagedate = TimeSpan.FromSeconds(averageseconds);

        }
        public static void StatsView(List<string> totalactivities, List<string> StartedActivities, List<string> CompletedActivities, List<DateTime> initialtime, List<DateTime> completedtime, List<TimeSpan> averagetime, List<string> stats, ref TimeSpan averagedate, List<int> activitiesperday, ref double averageseconds, ref int incomplete, ref int inprogress)
        {
            while (true)
            {
                Clear();
                stats.Clear();
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("STATS");
                ForegroundColor = ConsoleColor.White;
                string amountactivities = $"1. Total amount of activities: {totalactivities.Count} ";
                string incompleteactivties = $"2. Current amount of incomplete activities (Not started): {incomplete}";
                string inprogressactivities = $"3. Current amount of activities in progress: {inprogress}";
                string completedactivities = $"4. Current amount of completed activities: {CompletedActivities.Count}";
                string averagetimecompleted = $"5. Average time to complete an activity: {averagedate.Days} d, {averagedate.Hours} h, {averagedate.Minutes} m, {averagedate.Seconds} s.";
                string activitiesbyday = $"6. Acivities created today: {totalactivities.Count}";
                stats.Add(amountactivities);
                stats.Add(incompleteactivties);
                stats.Add(inprogressactivities);
                stats.Add(completedactivities);
                stats.Add(averagetimecompleted);
                stats.Add(activitiesbyday);
                for (int x = 0; x < stats.Count; x++)
                {
                    WriteLine($"{stats[x]}");
                }
                Write("Press any key to go back to the menu: ");
                ReadLine();
                Clear();
                break;
            }
        }
        enum status { Started }
    }
}