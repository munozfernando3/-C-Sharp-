using System;
using static System.Console;
using static System.Convert;

namespace Reminder // Note: actual namespace depends on the project name.
{
    public class SetAReminder
    {

        public static void MainReminder(ref List<DateTime> REMINDER, ref List<string> name)
        {
            Clear();
            Dictionary<DateTime, string> reminders = new Dictionary<DateTime, string>();
            bool exit = false;
            DateTime current = DateTime.Now;
            while (true)
            {

                Clear();
                ForegroundColor = ConsoleColor.White;
                Write("Name of the event: ");
                string? remindername = ReadLine();
                int year = AskForYear(ref exit, current);
                int month = AskForMonth(ref exit);
                int date = AskForDate(ref exit);

                if (exit == true)
                {
                    break;
                }

                DateTime reminder = new DateTime(year, month, date);
                ForegroundColor = ConsoleColor.White;
                WriteLine($"{remindername}: {reminder.Month}/{reminder.Day}/{reminder.Year}");
                REMINDER.Add(reminder);
                name.Add(remindername);
                ForegroundColor = ConsoleColor.DarkGray;
                try
                {
                    Write("Press 0 to go back. If you want to add another reminder press any key.");
                    int response = ToInt32(ReadLine());
                    if (response == 0)
                    {
                        Clear();
                        break;
                    }
                    else
                    {
                        Clear();
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. TRY AGAIN");
                }
            }


        }
        public static string AskForEvent(ref bool exit)
        {
            while (true)
            {
                const string title = $"SET A REMINDER";
                ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@$"{title,60}");
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("TYPE 'Exit' TO GO BACK: ");
                ForegroundColor = ConsoleColor.White;
                Write("Name of the event: ");
                string? remindername = ReadLine();
                if (remindername == "")
                {
                    Clear();
                    continue;
                }
                else if (remindername == "Exit" || remindername == "exit")
                {
                    Clear();
                    exit = true;
                    return "EXIT";
                }
                else
                {
                    Clear();
                    return remindername;

                }
            }
        }
        public static int AskForYear(ref bool exit, DateTime current)
        {
            while (true)
            {
                try
                {
                    if (exit == true)
                    {
                        return 0;
                    }
                    const string title = $"SET A REMINDER";
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@$"{title,60}");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE 0 TO EXIT: ");
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Write("Year: ");
                    ForegroundColor = ConsoleColor.White;
                    int year = ToInt32(ReadLine());
                    if (year == 0)
                    {
                        exit = true;
                    }
                    else if (year < current.Year || year == 0)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That year has already passed");
                        continue;
                    }
                    else
                    {
                        Clear();
                        return year;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. TRY AGAIN");
                    continue;
                }
            }
        }
        public static int AskForMonth(ref bool exit)
        {
            while (true)
            {
                try
                {
                    if (exit == true)
                    {
                        return 0;
                    }
                    const string title = $"SET A REMINDER";
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@$"{title,60}");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("1. January");
                    WriteLine("2. February");
                    WriteLine("3. March");
                    WriteLine("4. Abril");
                    WriteLine("5. May");
                    WriteLine("6. June");
                    WriteLine("7. July");
                    WriteLine("8. August");
                    WriteLine("9. September");
                    WriteLine("10. October");
                    WriteLine("11. November");
                    WriteLine("12. December");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE 0 TO EXIT: ");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    Write("Month: ");
                    ForegroundColor = ConsoleColor.White;
                    int month = ToInt32(ReadLine());
                    if (month == 0)
                    {
                        exit = true;

                    }

                    if ((month < 1 || month > 12))
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not a valid month");
                        continue;
                    }
                    else
                    {
                        Clear();
                        return month;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. TRY AGAIN");
                    continue;
                }
            }
        }
        public static int AskForDate(ref bool exit)
        {
            while (true)
            {
                try
                {
                    if (exit == true)
                    {
                        return 0;
                    }
                    const string title = $"SET A REMINDER";
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@$"{title,60}");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE 0 TO EXIT. CHOOSE A DAY BETWEEN 1-31");
                    ForegroundColor = ConsoleColor.DarkCyan;
                    Write("Date: ");
                    ForegroundColor = ConsoleColor.White;
                    int day = ToInt32(ReadLine());
                    if (day == 0)
                    {
                        exit = true;
                    }

                    if ((day < 1 || day > 31))
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not a valid day");
                        continue;
                    }
                    else
                    {
                        Clear();
                        return day;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. TRY AGAIN");
                    continue;
                }
            }
        }

    }
}
