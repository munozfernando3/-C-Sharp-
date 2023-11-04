using System;
using static System.Console;
using HistoryTrivia;
using MathTrivia;
using BiologyTrivia;
using GeographyTrivia;
using MoviesTrivia;

namespace Trivia // Note: actual namespace depends on the project name.
{
    public class Quizz
    {
        static string status = "INCOMPLETE";
        static int mathHighScore = 0;
        static int mathscore = 0;

        static int historyscore = 0;
        static int biologyscore = 0;
        static int geographyscore = 0;
        static int moviesscore = 0;
        static int mathcomplete = 0;
        static int historycomplete = 0;
        static int biologycomplete = 0;
        static int geographycomplete = 0;
        static int moviecomplete = 0;
        static int historyHighScore = 0;
        static int biologyHighScore = 0;
        static int geographyHighScore = 0;
        static int moviesHighScore = 0;
        static bool mathDone = false;
        static bool historyDone = false;
        static bool biologyDone = false;
        static bool geographyDone = false;
        static bool movieDone = false;

        public static void MainTrivia()
        {

            IfSaved(ref mathHighScore, ref mathDone, "Scores\\MathHighScore.txt", "Scores\\MathStatus.txt");
            IfSaved(ref historyHighScore, ref historyDone, "Scores\\HistoryHighScore.txt", "Scores\\HistoryStatus.txt");
            IfSaved(ref biologyHighScore, ref biologyDone, "Scores\\BiologyHighScore.txt", "Scores\\BiologyStatus.txt");
          IfSaved(ref geographyHighScore, ref geographyDone, "Scores\\GeographyHighScore.txt", "Scores\\GeographyStatus.txt");
           IfSaved(ref moviesHighScore, ref movieDone, "Scores\\MoviesHighScore.txt", "Scores\\MoviesStatus.txt");
            while (true)
            {
                int choice = PrincipalMenu();
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Clear();
                            int triviatype = TriviaMenu(ref status, ref mathscore, ref biologyscore, ref historyscore, ref geographyscore, ref moviesscore, ref mathcomplete, ref biologycomplete, ref historycomplete, ref geographycomplete, ref moviecomplete);
                            switch (triviatype)
                            {
                                case 1:
                                    Mathematics.MathTrivia(out mathscore, out mathcomplete, ref mathHighScore);
                                    if (mathcomplete == 16)
                                    {
                                        mathDone = true;
                                    }
                                    if (mathscore > mathHighScore)
                                    {
                                        mathHighScore = mathscore;
                                    }
                                    break;

                                case 2:
                                    Biology.BiologyTrivia(out biologyscore, out biologycomplete, ref biologyHighScore);
                                    if (biologycomplete == 16)
                                    {
                                        biologyDone = true;
                                    }
                                    if (biologyscore > biologyHighScore)
                                    {
                                        biologyHighScore = biologyscore;
                                    }
                                    break;

                                case 3:
                                    Clear();
                                    History.HistoryTrivia(out historyscore, out historycomplete, ref historyHighScore);
                                    if (historycomplete == 16)
                                    {
                                        historyDone = true;
                                    }
                                    if (historyscore > historyHighScore)
                                    {
                                        historyHighScore = historyscore;
                                    }
                                    break;
                                case 4:
                                    Geography.GeographyTrivia(out geographyscore, out geographycomplete, ref geographyHighScore);
                                    if (geographycomplete == 16)
                                    {
                                        geographyDone = true;
                                    }
                                    if (geographyscore > geographyHighScore)
                                    {
                                        geographyHighScore = geographyscore;
                                    }
                                    break;
                                     case 5:
                                    Movies.MoviesTrivia(out moviesscore, out moviecomplete, ref moviesHighScore);
                                    {
                                    if (moviecomplete == 16)
                                        movieDone = true;
                                    }
                                    if (moviesscore > moviesHighScore)
                                    {
                                       moviesHighScore = moviesscore;
                                    }
                                    break;

                            }
                            if (triviatype == 6)
                            {
                                Clear();
                                break;
                            }
                        }
                        break;

                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            ForegroundColor = ConsoleColor.Blue;
                            WriteLine("HOW TO PLAY ");
                            ForegroundColor = ConsoleColor.White;
                            WriteLine("Each section (Mathematics, geography, biology, history and movies) is divided into 2 or 3 mini-games, like for example; trivia, character guess, continue the story, and riddles. Every time you complete one of these minigames you will have more points and you will be able to finish and unlock more sections. For the multiple choice questions you must answer only with the letters ''a', 'b', 'c', and 'd'. If you get a question right you will have 20 more points, otherwise, if you answer wrong you will lose 10 points");
                            Write("Press any key to get back to the menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        break;
                }
                if (choice == 3)
                {
                    Clear();
                    break;
                }


            }

            SaveScores(mathDone, mathHighScore, "Scores\\MathHighScore.txt", "Scores\\MathStatus.txt");
            SaveScores(historyDone, historyHighScore, "Scores\\HistoryHighScore.txt", "Scores\\HistoryStatus.txt");
            SaveScores(biologyDone, biologyHighScore, "Scores\\BiologyHighScore.txt", "Scores\\BiologyStatus.txt");
            SaveScores(geographyDone, geographyHighScore, "Scores\\GeographyHighScore.txt", "Scores\\GeographyStatus.txt");
       SaveScores(movieDone, moviesHighScore, "Scores\\MoviesHighScore.txt", "Scores\\MoviesStatus.txt");
        }

        private static void SaveScores(bool SubjectDone, int SubjectHighScores, string namescore, string namedone)
        {
            string savedsubjectdone = Convert.ToString(SubjectDone);
            string savedsubjectscore = Convert.ToString(SubjectHighScores);
            Directory.CreateDirectory("Scores");
            File.WriteAllText($"{namedone}", String.Empty);
            File.WriteAllText($"{namedone}", savedsubjectdone);
            File.WriteAllText($"{namescore}", String.Empty);
            File.WriteAllText($"{namescore}", savedsubjectscore);
        }

        static int PrincipalMenu()
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NERDS GAME");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("1. PLAY GAME");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("2. HOW TO PLAY");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("3. EXIT");
                    ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the action you would like to do: ");

                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3)
                        return prompt;
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the option. TRY AGAIN");
                }
            }
        }
        public static void IfSaved(ref int SubjectHighScore, ref bool SubjectDone, string namescore, string namedone)
        {
            if (File.Exists($"{namedone}"))
            {
                string savedsubjectdone = File.ReadAllText($"{namedone}");
                SubjectDone = Convert.ToBoolean(savedsubjectdone);
            }
            if (File.Exists($"{namescore}"))
            {
                string savedsubjectscore = File.ReadAllText($"{namescore}");
                SubjectHighScore = Convert.ToInt32(savedsubjectscore);
            }
        }
        public static int TriviaMenu(ref string status, ref int mathscore, ref int biologyscore, ref int historyscore, ref int geographyscore, ref int moviesscore, ref int mathcomplete, ref int biologycomplete, ref int historycomplete, ref int geographycomplete, ref int moviecomplete)
        {
            while (true)
            {
                try
                {

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(@$"{"TRIVIAS",50}");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Blue;

                    DisplayRow("1.- MATH", mathDone, mathHighScore, ConsoleColor.Blue);
                    DisplayRow("2.- BIOLOGY", biologyDone, biologyHighScore, ConsoleColor.Green);
                    DisplayRow("3.- HISTORY", historyDone, historyHighScore, ConsoleColor.Yellow);
                    DisplayRow("4.- GEOGRAPHY", geographyDone, geographyHighScore, ConsoleColor.Cyan);
                    DisplayRow("5.- MOVIES", movieDone, moviesHighScore, ConsoleColor.Magenta);

                    Console.ForegroundColor = ConsoleColor.Red;

                    WriteLine("6.- BACK");
                    Console.ForegroundColor = ConsoleColor.White;
                    Write("Put the number of the action you would like to do: ");
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3 || prompt == 4 || prompt == 5 || prompt == 6)
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

        private static void DisplayRow(string subject, bool done, int highScore, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Write($"{subject,-17}");
            if (done)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Write(@$"{"COMPLETED",32}");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Write(@$"{"INCOMPLETE",32}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(@$"{highScore,22}/300");
        }
    }
}