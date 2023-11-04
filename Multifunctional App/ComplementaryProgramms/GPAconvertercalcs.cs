using System;
using static System.Console;

namespace GPACalcs
{
    public class CalculationsPerClass
    {
        public static void PercentageToGPA()
        {
            while (true)

            {
                try
                {

                    ForegroundColor = ConsoleColor.White;
                    int Count = AskForNumberofSubjects();
                    List<string> classes = new List<string>(Count);
                    Clear();
                    AskForNameofSubjects(Count, classes);
                    Clear();
                    List<double> grades = new List<double>(Count);
                    List<string> letter = new List<string>(Count);
                    List<double> average = new List<double>(Count);

                    AskForGradesPercent(Count, classes, grades, average, letter);
                    Clear();
                    DisplayResults(classes, ref grades, ref average, ref letter);

                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Press 'BackSpace' to go back.");
                    WriteLine("Press 'Esc' to edit, add or remove something");
                    WriteLine("Press 'Space' to restart.");
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Backspace)
                    {
                        Clear();
                        grades.Clear();
                        classes.Clear();
                        average.Clear();
                        letter.Clear();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        Edit(classes, grades, average, letter);
                        break;
                    }
                    else if (key == ConsoleKey.Spacebar)
                    {
                        Clear();
                        grades.Clear();
                        classes.Clear();
                        average.Clear();
                        letter.Clear();
                        continue;
                    }
                    else{
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

        public static void DisplayResults(List<string> classes, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {
            ForegroundColor = ConsoleColor.Blue;
            Write("Classes:");
            ForegroundColor = ConsoleColor.Green;
            Write($"{"Percentage %",33}");
            ForegroundColor = ConsoleColor.Magenta;
            Write($"{"GPA",30}");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Letter",30}");
            ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < classes.Count; x++)
            {
                for (int y = x; y < grades.Count;)
                {
                    for (int i = y; i < average.Count;)
                    {
                        for (int a = i; a < letter.Count;)
                        {
                            WriteLine($"{x + 1}. {classes[x],-30} {grades[y],-33} {average[i],-28} {letter[a]}");
                            break;
                        }
                        break;
                    }
                    break;
                }
            }

            double percentageaverage = TotalAveragePercentage(ref grades);
            double GPA = TotalAverageGPA(ref average);
            string finalletter = TotalAverageLetter(percentageaverage);
            WriteLine("-------------------------------------------------------------------------------------------------------");
            ForegroundColor = ConsoleColor.DarkRed;
            Write("SEMESTER GPA: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{GPA}");
            ForegroundColor = ConsoleColor.DarkBlue;
            Write($"SEMESTER PERCENTAGE: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{percentageaverage} %");
            ForegroundColor = ConsoleColor.DarkYellow;
            Write($"SEMESTER LETTER: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{finalletter}");
            WriteLine("-------------------------------------------------------------------------------------------------------");
        }
        public static void DisplayResults2(List<string> semesters, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {
            ForegroundColor = ConsoleColor.Blue;
            Write("Semesters:");
            ForegroundColor = ConsoleColor.Green;
            Write($"{"Percentage %",33}");
            ForegroundColor = ConsoleColor.Magenta;
            Write($"{"GPA",30}");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Letter",30}");
            ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < semesters.Count; x++)
            {
                for (int y = x; y < grades.Count;)
                {
                    for (int i = y; i < average.Count;)
                    {
                        for (int a = i; a < letter.Count;)
                        {
                            WriteLine($"{x + 1}. {semesters[x],-30} {grades[y],-33} {average[i],-28} {letter[a]}");
                            break;
                        }
                        break;
                    }
                    break;
                }
            }

            double percentageaverage = TotalAveragePercentage(ref grades);
            double GPA = TotalAverageGPA(ref average);
            string finalletter = TotalAverageLetter(percentageaverage);
            WriteLine("-------------------------------------------------------------------------------------------------------");
            ForegroundColor = ConsoleColor.DarkRed;
            Write("FINAL GPA: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{GPA}");
            ForegroundColor = ConsoleColor.DarkBlue;
            Write($"FINAL PERCENTAGE: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{percentageaverage} %");
            ForegroundColor = ConsoleColor.DarkYellow;
            Write($"FINAL LETTER: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{finalletter}");
            WriteLine("-------------------------------------------------------------------------------------------------------");
        }
        public static void DisplayResults3(List<string> terms, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {
            ForegroundColor = ConsoleColor.Blue;
            Write("Terms");
            ForegroundColor = ConsoleColor.Green;
            Write($"{"Percentage %",33}");
            ForegroundColor = ConsoleColor.Magenta;
            Write($"{"GPA",30}");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Letter",30}");
            ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < terms.Count; x++)
            {
                for (int y = x; y < grades.Count;)
                {
                    for (int i = y; i < average.Count;)
                    {
                        for (int a = i; a < letter.Count;)
                        {
                            WriteLine($"{x + 1}. {terms[x],-30} {grades[y],-33} {average[i],-28} {letter[a]}");
                            break;
                        }
                        break;
                    }
                    break;
                }
            }

            double percentageaverage = TotalAveragePercentage(ref grades);
            double GPA = TotalAverageGPA(ref average);
            string finalletter = TotalAverageLetter(percentageaverage);
            WriteLine("-------------------------------------------------------------------------------------------------------");
            ForegroundColor = ConsoleColor.DarkRed;
            Write("SEMESTER GPA: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{GPA}");
            ForegroundColor = ConsoleColor.DarkBlue;
            Write($"SEMESTER PERCENTAGE: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{percentageaverage} %");
            ForegroundColor = ConsoleColor.DarkYellow;
            Write($"SEMESTER LETTER: ");
            ForegroundColor = ConsoleColor.White;
            WriteLine($"{finalletter}");
            WriteLine("-------------------------------------------------------------------------------------------------------");
        }

        public static void RemoveAClass(List<string> classes, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                try
                {

                    ForegroundColor = ConsoleColor.White;
                    WriteLine("0. Back");
                    DisplayResults(classes, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("REMOVE A CLASS");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the row you would like to remove. This will remove the class and its grades");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(" Put '0' if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    Write("Row: ");
                    int remove = Convert.ToInt32(ReadLine());
                    if (remove == 0)
                    {
                        break;
                    }
                    if (remove > classes.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }
                    else
                    {
                        Clear();
                        for (int x = remove - 1; x < classes.Count;)
                        {
                            classes.RemoveAt(remove - 1);
                            grades.RemoveAt(remove - 1);
                            average.RemoveAt(remove - 1);
                            letter.RemoveAt(remove - 1);
                            break;
                        }
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
        public static void RemoveASemester(List<string> semesters, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("0. Back");
                    DisplayResults2(semesters, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("REMOVE A SEMESTER");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the row you would like to remove. This will remove the class and its grades");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(" Put '0' if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    Write("Row: ");
                    int remove = Convert.ToInt32(ReadLine());
                    if (remove == 0)
                    {
                        break;
                    }
                    if (remove > semesters.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }
                    else
                    {
                        Clear();
                        for (int x = remove - 1; x < semesters.Count;)
                        {
                            semesters.RemoveAt(remove - 1);
                            grades.RemoveAt(remove - 1);
                            average.RemoveAt(remove - 1);
                            letter.RemoveAt(remove - 1);
                            break;
                        }
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
        public static void RemoveATerm(List<string> terms, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("0. Back");
                    DisplayResults3(terms, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("REMOVE A TERM");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the row you would like to remove. This will remove the class and its grades");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(" Put '0' if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    Write("Row: ");
                    int remove = Convert.ToInt32(ReadLine());
                    if (remove == 0)
                    {
                        break;
                    }
                    if (remove > terms.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }
                    else
                    {
                        Clear();
                        for (int x = remove - 1; x < terms.Count;)
                        {
                            terms.RemoveAt(remove - 1);
                            grades.RemoveAt(remove - 1);
                            average.RemoveAt(remove - 1);
                            letter.RemoveAt(remove - 1);
                            break;
                        }
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
        public static void ChangePercentage(List<string> classes, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {
            while (true)
            {
                try
                {

                    WriteLine("0. Back");
                    DisplayResults(classes, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("CHANGE A GRADE");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the row where the percentage you want to change is located");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(" Put '0' if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    Write("Row: ");
                    int change = Convert.ToInt32(ReadLine());
                    if (change == 0)
                    {
                        break;
                    }
                    if (change > classes.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine($"Class: {classes[change - 1]}     Current percentage: {grades[change - 1]}");
                        ForegroundColor = ConsoleColor.White;
                        Write("New percentage: ");
                        double newp = Convert.ToDouble(ReadLine());
                        if (newp < 0 || newp > 100)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("That is out of range. Try again");
                            continue;
                        }
                        else
                        {
                            double newround = Math.Round(newp, 2);
                            for (int x = change - 1; x < classes.Count;)
                            {
                                Clear();
                                grades[change - 1] = newround;
                                double gpachange = GPAPerSubjectWithoutAddingLetter(newround);
                                average[change - 1] = gpachange;
                                string newletter = TotalAverageLetter(newround);
                                letter[change - 1] = newletter;
                                break;
                            }
                            continue;
                        }
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
        public static void ChangePercentage2(List<string> semesters, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {
            while (true)
            {
                try
                {

                    WriteLine("0. Back");
                    DisplayResults2(semesters, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("CHANGE A GRADE");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the row where the percentage you want to change is located");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine(" Put '0' if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    Write("Row: ");
                    int change = Convert.ToInt32(ReadLine());
                    if (change == 0)
                    {
                        break;
                    }
                    if (change > semesters.Count)
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not within the range. Try again");
                        continue;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine($"Semester: {semesters[change - 1]}     Current percentage: {grades[change - 1]}");
                        ForegroundColor = ConsoleColor.White;
                        Write("New percentage: ");
                        double newp = Convert.ToDouble(ReadLine());
                        if (newp < 0 || newp > 100)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("That is out of range. Try again");
                            continue;
                        }
                        else
                        {
                            double newround = Math.Round(newp, 2);
                            for (int x = change - 1; x < semesters.Count;)
                            {
                                Clear();
                                grades[change - 1] = newround;
                                double gpachange = GPAPerSubjectWithoutAddingLetter(newround);
                                average[change - 1] = gpachange;
                                string newletter = TotalAverageLetter(newround);
                                letter[change - 1] = newletter;
                                break;
                            }
                            continue;
                        }
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
        public static void AddAClass(List<string> classes, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                try
                {

                    ForegroundColor = ConsoleColor.White;
                    DisplayResults(classes, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine("ADD A CLASS");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Type 'Back' if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    Write("Name of the class: ");
                    string name = ReadLine();
                    if (name == "Back" || name == "back")
                    {
                        break;
                    }
                    else if (name == "")
                    {
                        Clear();
                        continue;
                    }
                    else
                    { 

                        Write($"Percentage in {name}: ");
                        double percent = Convert.ToDouble(ReadLine());
                        if (percent > 100 || percent < 0)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("That is not valid. Try again");
                            continue;
                        }
                        else
                        {
                            double GPAadded = GPAPerSubject(percent, letter);
                            Clear();
                            classes.Add(name);
                            grades.Add(percent);
                            average.Add(GPAadded);
                            continue;
                        }


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
        public static void AddASemester(List<string> semesters, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                try
                {
                    WriteLine("-1. Back");
                    ForegroundColor = ConsoleColor.White;
                    DisplayResults2(semesters, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine("ADD A SEMESTER");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Put -1 if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    string semesternumber = $"Semester {semesters.Count + 1}";
                    Write($"Percentage in {semesternumber}: ");
                    double percent = Convert.ToDouble(ReadLine());
                    if (percent == -1)
                    {
                        Clear();
                        break;
                    }
                    else if (percent != -1 && (percent > 100 || percent < 0))
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
                        continue;
                    }

                    else
                    {
                        double GPAadded = GPAPerSubject(percent, letter);
                        Clear();
                        semesters.Add(semesternumber);
                        grades.Add(percent);
                        average.Add(GPAadded);
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
        public static void AddATerm(List<string> terms, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                try
                {
                    WriteLine("-1. Back");
                    ForegroundColor = ConsoleColor.White;
                    DisplayResults3(terms, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine("ADD A TERM");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Put -1 if you wanna go back.");
                    ForegroundColor = ConsoleColor.White;
                    string semesternumber = $"Term {terms.Count + 1}";
                    Write($"Percentage in {semesternumber}: ");
                    double percent = Convert.ToDouble(ReadLine());
                    if (percent == -1)
                    {
                        Clear();
                        break;
                    }
                    else if (percent != -1 && (percent > 100 || percent < 0))
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
                        continue;
                    }

                    else
                    {
                        double GPAadded = GPAPerSubject(percent, letter);
                        Clear();
                        terms.Add(semesternumber);
                        grades.Add(percent);
                        average.Add(GPAadded);
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

        public static void Edit(List<string> classes, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                int choice = EditMenu(classes, ref grades, ref average, ref letter);

                switch (choice)
                {
                    case 1:
                        Clear();
                        AddAClass(classes, grades, average, letter);
                        break;
                    case 2:
                        Clear();
                        RemoveAClass(classes, grades, average, letter);
                        break;
                    case 3:
                        Clear();
                        ChangePercentage(classes, ref grades, ref average, ref letter);
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }
        public static void Edit2(List<string> terms, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                int choice = EditMenu3(terms, ref grades, ref average, ref letter);

                switch (choice)
                {
                    case 1:
                        Clear();
                        AddATerm(terms, grades, average, letter);
                        break;
                    case 2:
                        Clear();
                        RemoveATerm(terms, grades, average, letter);
                        break;
                    case 3:
                        Clear();
                        ChangePercentage2(terms, ref grades, ref average, ref letter);
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }
        public static void Edit3(List<string> terms, List<double> grades, List<double> average, List<string> letter)
        {
            while (true)
            {
                int choice = EditMenu3(terms, ref grades, ref average, ref letter);

                switch (choice)
                {
                    case 1:
                        Clear();
                        AddATerm(terms, grades, average, letter);
                        break;
                    case 2:
                        Clear();
                        RemoveATerm(terms, grades, average, letter);
                        break;
                    case 3:
                        Clear();
                        ChangePercentage2(terms, ref grades, ref average, ref letter);
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }

        }
        public static int EditMenu(List<string> classes, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {

            while (true)
            {
                try
                {
                    Clear();
                    DisplayResults(classes, ref grades, ref average, ref letter);
                    Write($"{"1. Add",20}");
                    Write($"{"2. Remove",20}");
                    Write($"{"3 Edit",20}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"{"4 Back",20}");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write(" Put the number of the action you would like to do: ");
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
                    WriteLine("That is not valid. Try again");
                }


            }
        }
        public static int EditMenu2(List<string> semesters, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {

            while (true)
            {
                try
                {
                    Clear();
                    DisplayResults2(semesters, ref grades, ref average, ref letter);
                    Write($"{"1. Add",20}");
                    Write($"{"2. Remove",20}");
                    Write($"{"3 Edit",20}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"{"4 Back",20}");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write(" Put the number of the action you would like to do: ");
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
                    WriteLine("That is not valid. Try again");
                }


            }
        }
        public static int EditMenu3(List<string> terms, ref List<double> grades, ref List<double> average, ref List<string> letter)
        {

            while (true)
            {
                try
                {
                    Clear();
                    DisplayResults2(terms, ref grades, ref average, ref letter);
                    Write($"{"1. Add",20}");
                    Write($"{"2. Remove",20}");
                    Write($"{"3 Edit",20}");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"{"4 Back",20}");
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write(" Put the number of the action you would like to do: ");
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
                    WriteLine("That is not valid. Try again");
                }


            }
        }
        public static int AskForNumberofSubjects()
        {
            while (true)
            {
                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.White;
                    Write("Tell me how many subjects do you have: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    return length;
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not in the options. Try again");
                }
            }
        }
        public static void AskForNameofSubjects(int Count, List<string> classes)
        {
            int x = 0;
            while (true && x < Count)
            {
                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Tell me the name of your {Count} classes. Start with one of them. ");

                    for (x = 0; x < Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        Console.Write($"Class {x + 1}: ");
                        string? userclasses = ReadLine();
                        if (userclasses == "")
                        {
                            Clear();
                            WriteLine("That is not valid. Try again");
                            break;
                        }
                        else
                        {
                            classes.Add(userclasses);
                        }
                    }
                    continue;
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not a name. Try again");
                }
            }
        }
        public static void AskForGradesPercent(int Count, List<string> classes, List<double> grades, List<double> average, List<string> letter)
        {
            int x = 0;
            while (true && x < classes.Count)
            {

                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Tell me the current percentage of each class. Do not write the % sign. ");
                    for (x = 0; x < classes.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        Console.Write($"{classes[x]}: ");
                        double userpercentage = Convert.ToSingle(ReadLine());
                        if (userpercentage < 0 || userpercentage > 100)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("That is out of ramge. Try Again.");
                            grades.Clear();
                            average.Clear();
                            break;
                        }
                        
                            double userpercentageround = Math.Round(userpercentage, 2);
                            grades.Add(userpercentageround);
                            average.Add(GPAPerSubject(userpercentage, letter));
                        
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not a number. Try again");
                }

            }
        }
        public static void AskForGradesPercent2(int Count, List<string> semesters, List<double> grades, List<double> average, List<string> letter)
        {
            int x = 0;
            while (true && x < semesters.Count)
            {

                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Tell me the current percentage of each semester. Do not write the % sign. ");
                    for (x = 0; x < semesters.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        Console.Write($"{semesters[x]}: ");
                        double userpercentage = Convert.ToSingle(ReadLine());
                        if (userpercentage < 0 || userpercentage > 100)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("That is out of ramge. Try Again.");
                            break;
                        }
                        else
                        {
                            double userpercentageround = Math.Round(userpercentage, 2);
                            grades.Add(userpercentageround);
                            average.Add(GPAPerSubject(userpercentage, letter));
                            continue;
                        }
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not a number. Try again");
                }

            }
        }
        public static void AskForGradesPercent3(int Count, List<string> terms, List<double> grades, List<double> average, List<string> letter)
        {
            int x = 0;
            while (true && x < terms.Count)
            {

                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Tell me the current percentage of each term. Do not write the % sign. ");
                    for (x = 0; x < terms.Count; x++)
                    {
                        ForegroundColor = ConsoleColor.White;
                        Console.Write($"{terms[x]}: ");
                        double userpercentage = Convert.ToSingle(ReadLine());
                        if (userpercentage < 0 || userpercentage > 100)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("That is out of ramge. Try Again.");
                            break;
                        }
                        else
                        {
                            double userpercentageround = Math.Round(userpercentage, 2);
                            grades.Add(userpercentageround);
                            average.Add(GPAPerSubject(userpercentage, letter));
                            continue;
                        }
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not a number. Try again");
                }

            }
        }
        public static double GPAPerSubjectWithoutAddingLetter(double percentage)
        {
            if (percentage <= 100 && percentage >= 94)
            {

                return 4.0;
            }
            else if (percentage < 94 && percentage >= 90)
            {
                return 3.7;
            }
            else if (percentage < 90 && percentage >= 87)
            {
                return 3.3;
            }
            else if (percentage < 87 && percentage >= 84)
            {
                return 3.0;
            }
            else if (percentage < 84 && percentage >= 80)
            {
                return 2.7;
            }
            else if (percentage < 80 && percentage >= 77)
            {

                return 2.3;
            }
            else if (percentage < 77 && percentage >= 74)
            {

                return 2.0;
            }
            else if (percentage < 74 && percentage >= 70)
            {
                return 1.7;
            }
            else if (percentage < 70 && percentage >= 67)
            {

                return 1.3;
            }
            else if (percentage < 67 && percentage >= 64)
            {

                return 1.0;
            }
            else if (percentage < 64 && percentage >= 60)
            {

                return 0.7;
            }
            else
            {

                return 0.0;
            }
        }
        static double GPAPerSubject(double percentage, List<string> letter)
        {
            if (percentage <= 100 && percentage >= 94)
            {

                letter.Add("A");
                return 4.0;
            }
            else if (percentage < 94 && percentage >= 90)
            {
                letter.Add("A-");
                return 3.7;
            }
            else if (percentage < 90 && percentage >= 87)
            {

                letter.Add("B+");
                return 3.3;
            }
            else if (percentage < 87 && percentage >= 84)
            {

                letter.Add("B");
                return 3.0;
            }
            else if (percentage < 84 && percentage >= 80)
            {
                letter.Add("B-");
                return 2.7;
            }
            else if (percentage < 80 && percentage >= 77)
            {
                letter.Add("C+");
                return 2.3;
            }
            else if (percentage < 77 && percentage >= 74)
            {
                letter.Add("C");
                return 2.0;
            }
            else if (percentage < 74 && percentage >= 70)
            {
                letter.Add("C-");
                return 1.7;
            }
            else if (percentage < 70 && percentage >= 67)
            {
                letter.Add("D+");
                return 1.3;
            }
            else if (percentage < 67 && percentage >= 64)
            {
                letter.Add("D");
                return 1.0;
            }
            else if (percentage < 64 && percentage >= 60)
            {
                letter.Add("D-");
                return 0.7;
            }
            else
            {
                letter.Add("F");
                return 0.0;
            }

        }
        public static double TotalAveragePercentage(ref List<double> grades)
        {
            double total = 0;
            for (int x = 0; x < grades.Count; x++)
            {
                total += grades[x];
            }
            double average = (double)total / grades.Count;
            double averageround = Math.Round(average, 2);
            return averageround;
        }
        public static string TotalAverageLetter(double percentage)
        {
            if (percentage <= 100 && percentage >= 94)
            {
                return "A";
            }
            else if (percentage < 94 && percentage >= 90)
            {
                return "A-";
            }
            else if (percentage < 90 && percentage >= 87)
            {


                return "B+";
            }
            else if (percentage < 87 && percentage >= 84)
            {

                return "B";
            }
            else if (percentage < 84 && percentage >= 80)
            {
                return "B-";
            }
            else if (percentage < 80 && percentage >= 77)
            {
                return "C-";
            }
            else if (percentage < 77 && percentage >= 74)
            {
                return "C";
            }
            else if (percentage < 74 && percentage >= 70)
            {
                return "C-";
            }
            else if (percentage < 70 && percentage >= 67)
            {
                return "D+";
            }
            else if (percentage < 67 && percentage >= 64)
            {
                return "D";
            }
            else if (percentage < 64 && percentage >= 60)
            {
                return "D-";
            }
            else
            {
                return "F";
            }
        }
        public static double TotalAverageGPA(ref List<double> averagelist)
        {
            double total = 0;
            for (int x = 0; x < averagelist.Count; x++)
            {
                total += averagelist[x];
            }
            double average = (double)total / averagelist.Count;
            double averageround = Math.Round(average, 2);
            return averageround;
        }
    }
    public class CalculationsPerSemester
    {
        public static void PercentageToGPA()
        {
            while (true)

            {
                try
                {
                    List<string> semesters = new List<string>();
                    ForegroundColor = ConsoleColor.White;
                    int Count = AskForNumberofSemesters(ref semesters);

                    Clear();
                    List<double> grades = new List<double>(Count);
                    List<string> letter = new List<string>(Count);
                    List<double> average = new List<double>(Count);

                    CalculationsPerClass.AskForGradesPercent2(Count, semesters, grades, average, letter);
                    Clear();
                    CalculationsPerClass.DisplayResults2(semesters, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Press 'BackSpace' to go back.");
                    WriteLine("Press 'Esc' to edit, add or remove something");
                    WriteLine("Press 'Space' to restart.");
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Backspace)
                    {
                        Clear();
                        grades.Clear();
                        semesters.Clear();
                        average.Clear();
                        letter.Clear();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        CalculationsPerClass.Edit2(semesters, grades, average, letter);
                        break;
                    }
                    else if (key == ConsoleKey.Spacebar)
                    {
                        Clear();
                        grades.Clear();
                        semesters.Clear();
                        average.Clear();
                        letter.Clear();
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

        public static int AskForNumberofSemesters(ref List<string> semesters)
        {
            while (true)
            {
                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.White;
                    Write("Tell me how many semesters have you studied?: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    for (int x = 0; x < length; x++)
                    {
                        semesters.Add($"Semester {x + 1}");
                    }
                    return length;
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
    public class CalculationsPerTerm
    {
        public static void PercentageToGPA()
        {
            while (true)

            {
                try
                {
                    List<string> terms = new List<string>();
                    ForegroundColor = ConsoleColor.White;
                    int Count = AskForNumberofTerms(ref terms);

                    Clear();
                    List<double> grades = new List<double>(Count);
                    List<string> letter = new List<string>(Count);
                    List<double> average = new List<double>(Count);

                    CalculationsPerClass.AskForGradesPercent3(Count, terms, grades, average, letter);
                    Clear();
                    CalculationsPerClass.DisplayResults3(terms, ref grades, ref average, ref letter);
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("Press 'BackSpace' to go back.");
                    WriteLine("Press 'Esc' to edit, add or remove something");
                    WriteLine("Press 'Space' to restart.");
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Backspace)
                    {
                        Clear();
                        grades.Clear();
                        terms.Clear();
                        average.Clear();
                        letter.Clear();
                        break;
                    }
                    else if (key == ConsoleKey.Escape)
                    {
                        CalculationsPerClass.Edit3(terms, grades, average, letter);
                        break;
                    }
                    else if (key == ConsoleKey.Spacebar)
                    {
                        Clear();
                        grades.Clear();
                        terms.Clear();
                        average.Clear();
                        letter.Clear();
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
        public static int AskForNumberofTerms(ref List<string> terms)
        {
            while (true)
            {
                try
                {
                    string title = "GPA CALCULATOR";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.White;
                    Write("Tell me how many terms do you have?: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    for (int x = 0; x < length; x++)
                    {
                        terms.Add($"Term {x + 1}");
                    }
                    return length;
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


