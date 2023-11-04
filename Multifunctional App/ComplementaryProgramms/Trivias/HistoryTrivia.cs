using System;
using static System.Console;

namespace HistoryTrivia // Note: actual namespace depends on the project name.
{
    public class History
    {

        public static void HistoryTrivia(out int score, out int question, ref int HIGHSCORE)
        {

            while (true)
            {
                question = 1;
                score = 0;
                int life = 3;
                char answer = 'a';
                bool exit = false;
                Clear();
                ForegroundColor = ConsoleColor.White;
                Question1(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question2(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question3(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question4(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question5(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question6(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
               Question7(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                 Question8(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question9(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question10(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question11(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question12(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question13(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question14(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question15(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                if (exit == true)
                {
                    break;
                }
                if (life == 0)
                {
                    ConsoleKey key = Lost(ref score, ref HIGHSCORE);
                    if (key == ConsoleKey.Enter)
                        continue;
                    else if (key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                else
                {
                    if (score > HIGHSCORE)
                    {
                        HIGHSCORE = score;
                    }

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine($"{"CONGRATSSS!!!!",50}");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("YOU HAVE COMPLETED THE TRIVIA ");
                    ForegroundColor = ConsoleColor.Cyan;
                    Write($"FINAL SCORE: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{score}");
                    ForegroundColor = ConsoleColor.Yellow;
                    Write($"MAX SCORE: ");
                    ForegroundColor = ConsoleColor.White;
                    if (score < HIGHSCORE)
                    {
                        WriteLine($"{HIGHSCORE}");
                    }
                    else if (score == HIGHSCORE)
                    {
                        WriteLine($"{score}");
                    }
                    ForegroundColor = ConsoleColor.DarkGray;
                    Write("Press Esc if you want to go back to the menu, or  Press Enter if you want to play again: ");
                    ConsoleKey key2 = Console.ReadKey().Key;
                    if (key2 == ConsoleKey.Enter)
                        continue;
                    else if (key2 == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
        }

        static ConsoleKey Lost(ref int score, ref int HIGHSCORE)
        {
            while (true)
            {
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"{"YOU LOST",50}");
                  ForegroundColor = ConsoleColor.DarkRed;
                    Write($"FINAL SCORE: ");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine($"{score}");
                    ForegroundColor = ConsoleColor.Yellow;
                    Write($"MAX SCORE: ");
                    ForegroundColor = ConsoleColor.White;
                     if (score < HIGHSCORE)
                    {
                        WriteLine($"{HIGHSCORE}");
                    }
                    else if (score == HIGHSCORE)
                    {
                        WriteLine($"{score}");
                    }
                      ForegroundColor = ConsoleColor.DarkGray;
                Write("Press 'Enter' if you wanna try again, or press Esc if you want to go back to the menu: ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter || key == ConsoleKey.Escape)
                {
                    return key;
                }
                else
                {
                    continue;
                }
            }

        }
        static void Question1(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Who was the author of 'The odyssey'?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Homer");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Stephen King");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Aristotle");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Hesiod");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question2(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Who was the fourth president of the United States?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Tomas Jefferson");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) George Washington");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) James Madison");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Abraham Lincoln");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question3(ref char ANSWER, int life, bool exit, int score, int question)

        {
            while (true)
            {
                try
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Which era marked a switch from agricultural practices to industrial practices?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) French Revolution");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) The Industrial Revolution");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Agricultural Revolution");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The Renaissance");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Status(ref int question, ref int score, ref int life)
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"Question {question}");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"Score: {score}           Lifes: {life}");
        }
        static void CorrectAnswer()
        {
            ForegroundColor = ConsoleColor.Green;
            Write("CORRECT");
            ForegroundColor = ConsoleColor.Green;
            WriteLine(@"    +20 pts", 20);
        }
        static void WrongAnswer(ref int score, ref int life)
        {
            ForegroundColor = ConsoleColor.Red;
            Write("INCORRECT");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(@"    -1 life", 20);
            score += 0;
            life -= 1;
        }
        static void Question4(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("How many U.S. presidents have been assassinated?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 3");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 6");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 10");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 4");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question5(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What year did women receive the right to vote in the United States??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 1923");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 1823");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 1886");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 1920");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question6(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What year did the Berlin wall fall?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 1989");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 1889");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 1991");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 1990");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question7(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Who was prime minister of the UK for most of the Second World War?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Margareth Thatcher");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Winston Churchil");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Anthony Eden");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Harold McMillan");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question8(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("In which country in ancient times was mummification carried out on important people when they died?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Ancient Greece");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Ancient China");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Ancient India");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Ancient Egypt");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question9(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What was the date of the Boston Tea Party?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Dec. 16, 1773,");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Dec. 23, 1774");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Dec. 17, 1773");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Dec, 16 1774");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question10(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("How old was Queen Elizabeth II when she was crowned the Queen of England?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 19");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 22");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 27");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 76");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question11(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Adolf Hitler was born in which country?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Germany");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) England");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Austria");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) France");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question12(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("The disease that ravaged and killed a third of Europe's population in the 14th century is known as:");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Malaria");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) The Gray Death");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) The Black Death");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The Black Poison");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question13(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Which man wrote a document known as the 95 Theses?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Voltaire");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Saint August");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Martin Luther");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The Pope");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question14(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("The ancient Egyptians used to sleep on pillows made of");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Stone");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Cotton");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Wood");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Gold");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        static void Question15(ref char ANSWER, int life, bool exit, int score, int question)
        {
            while (true)
            {
                try
                { if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Which is the oldest civilization in the world?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Egypt");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) China");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Greece");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Mesopotamia");
                     ForegroundColor = ConsoleColor.Red;
                    WriteLine("e) Exit");
                    ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("TYPE JUST THE LETTER OF THE ANSWER");
                    ForegroundColor = ConsoleColor.White;
                    Write("Answer: ");
                    char answer = Convert.ToChar(ReadLine());
                    Clear();
                    if (answer == 'a' || answer == 'b' || answer == 'c' || answer == 'd' || answer == 'e')
                    {
                        ANSWER = answer;
                        Clear();
                        break;
                    }
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
        public static void CheckAnswer(char answer, char rightanswer, ref int question, ref int score, ref int life, ref bool exit)
        {
            while (true)
            {
                if (answer == 'e')
                {
                    exit = true;
                    break;
                }
                if (life == 0)
                {
                    break;
                }
                if (answer == rightanswer)
                {
                    Clear();
                    CorrectAnswer();
                    score += 20;
                    question++;
                    break;
                }
                else if (answer != rightanswer)
                {
                    Clear();
                    WrongAnswer(ref score, ref life);
                    question++;
                    break;
                }
            }
        }

    }
}
