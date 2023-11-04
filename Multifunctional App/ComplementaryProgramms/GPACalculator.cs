using System;
using static System.Console;
using static System.ConsoleColor;
using GPACalcs;
namespace GPACalculator
{
    public class GPACALCULATOR
    {
        public static void MainGPACalculator()
        {
            while (true)
            {

                int GPAMenu = Menu();
                switch (GPAMenu)
                {
                    case 1:
                        MenuPercentageTo();
                        break;
                    case 2:
                        ScaleChart();
                        break;
                }
                if (GPAMenu == 3)
                    break;
            }
        }
        //             
        public static int Menu()
        {
            while (true)
            {
                try
                {

                    string title = "GPA CALCULATOR MENU";
                    ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("1. Calculate GPA");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. See scale chart");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("3. Exit.");

                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Type the number of the action you want to do: ");
                    ForegroundColor = ConsoleColor.White;
                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3)
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


        public static void MenuPercentageTo()
        {
            while (true)
            {
                int menu = MenuPercentageToOptions();
                switch (menu)
                {
                    case 1:
                        CalculationsPerClass.PercentageToGPA();
                        break;
                    case 2:
                        CalculationsPerSemester.PercentageToGPA();
                        break;
                    case 3:
                        CalculationsPerTerm.PercentageToGPA();
                        break;
                }
                if (menu == 4)
                    break;
            }
        }


        public static int MenuPercentageToOptions()
        {
            while (true)
            {
                try
                {
                    string title = "PERCENTAJE TO GPA/LETTER";
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@$"{title,50}");
                    ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"Select an option that fits what you need");
                    ForegroundColor = ConsoleColor.Magenta;
                    Write("1. ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("GPA per Class");
                    ForegroundColor = ConsoleColor.Blue;
                    Write("2. ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("GPA per Semester");
                    ForegroundColor = ConsoleColor.Green;
                    Write("3. ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("GPA per Term");
                    ForegroundColor = ConsoleColor.Red;
                    Write("4. ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Exit");
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





        public static void ScaleChart()
        {
            while (true)
            {
                string title = "SCALE CHART";
                ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@$"{title,50}");
                ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@$"This chart is exclusibely for students from Snow College. If you are attending other college, it may change.");
                WriteLine(" ");
                ForegroundColor = ConsoleColor.Yellow;
                Write($"{"Letter Grade"}");
                ForegroundColor = ConsoleColor.Red;
                Write($"{"Percentile Range",32}");
                ForegroundColor = ConsoleColor.Green;
                WriteLine($"{"Grade Points",32}");
                ForegroundColor = ConsoleColor.White;
                Write($"{"A"}");
                Write($"{"94 to 100%",40}");
                WriteLine($"{"4.0",30}");
                Write($"{"A-"}");
                Write($"{"90 to <94%",39}");
                WriteLine($"{"3.7",30}");
                Write($"{"B+"}");
                Write($"{"87 to <90%",39}");
                WriteLine($"{"3.3",30}");
                Write($"B");
                Write($"{"84 to <87%",40}"); ;
                WriteLine($"{"3.0",30}");
                Write("B-");
                Write($"{"80 to <84%",39}");
                WriteLine($"{"2.7",30}");
                Write("C+");
                Write($"{"77 to <80%",39}");
                WriteLine($"{"2.3",30}");
                Write("C");
                Write($"{"74 to <77%",40}");
                WriteLine($"{"2.0",30}");
                Write("C-");
                Write($"{"70 to <74%",39}");
                WriteLine($"{"1.7",30}");
                Write("D+");
                Write($"{"67 to <70%",39}");
                WriteLine($"{"1.3",30}");
                Write("D");
                Write($"{"64 to <67%",40}");
                WriteLine($"{"1.0",30}");
                Write("D-");
                Write($"{"60 to <64%",39}");
                WriteLine($"{"0.7",30}");
                Write("F");
                Write($"{"0 to <60%",40}");
                WriteLine($"{"0.0",30}");
                WriteLine(" ");
                ForegroundColor = ConsoleColor.DarkGray;
                Write("Press any Key to go back: ");
                ReadKey();
                Clear();
                break;

            }
        }
    }
}