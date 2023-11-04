using System;
using static System.Console;

namespace MathTrivia // Note: actual namespace depends on the project name.
{
    public class Mathematics
    {

        public static void MathTrivia(out int score, out int question, ref int HIGHSCORE)
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
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question2(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question3(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question4(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question5(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question6(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question7(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question8(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question9(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question10(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question11(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question12(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question13(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question14(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
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
                    WriteLine("What does Triple means?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Add 3");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Multiply by 3");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Subtract 3");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Divide by 3");
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
                    WriteLine("9*(6 + 6) + 30 / 3?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 30");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 138 / 3");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 118");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 198");
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
                    WriteLine("What is 1/5 of 100? ?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 20");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 25");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 24");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 50");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What is 512/88 in lowest terms (simplified)??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 256/44");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 64/11");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 8/11");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 9/22");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("In an ordered pair, what is the value that is always written first?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) y-coordinate");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) x-axis");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) z-axis");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) x-coordinate");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Factorize: 6x^2 + 17x + 12?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) (2x+3)(3x+4))");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) (3x+3)(2x+4)");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) (2x+3)(3x+2)");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) (2x-3)(3x-2)");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("2(a + 3) = ");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a)  2a + 3");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 2a + 6");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) a+6 ");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) a + 3 / 2");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("27 - [5 + {28 - (29 - 7}]?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) -5");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 0");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 16");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 29");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What is the name of an angle of more than 90 degrees but less than 180 degrees?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Right Angle");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Vertical Angle");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Obtuse Angle");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Acute Angle");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What is the net prime number following the number 7?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 11");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 9");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 13");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 8");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("A is 40% of B. What percentage is B of A?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 40%");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 140%");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 60%");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 250%");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("2X+6=10. Then x equals: ");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 8");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 2");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) -2");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) -1");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("If you have to wait for 12 hours, how many minutes will you be waiting?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 7200");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 1200");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 720");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 600");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("What is 5 to the power of 0?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 0");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 1");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 5");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Undefined");
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
                {
                    if (life == 0 || exit == true)
                    {
                        break;
                    }
                    Status(ref question, ref score, ref life);
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Icosahedrons have how many equal sides?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 15");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 18");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 50");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 20");
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
