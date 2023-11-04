using System;
using static System.Console;

namespace GeographyTrivia // Note: actual namespace depends on the project name.
{
    public class Geography
    {

        public static void GeographyTrivia(out int score, out int question, ref int HIGHSCORE)
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
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question2(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question3(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question4(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question5(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question6(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question7(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question8(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question9(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question10(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question11(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question12(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question13(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question14(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question15(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
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
                Write("Press 'Enter' if you wanna try again, or press Esc if you want to go back to the menu.");
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
                    WriteLine("What is the capital of Brazil?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) La Paz");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Rio de Janeiro");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Brazil");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Brasilia");
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
                    WriteLine("On which continent is the Sahara Desert located??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Asia");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Africa");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Europe");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) America");
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
                    WriteLine("In which US state can you find the city of Chicago?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Luisana");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Los Angeles");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Illinois");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Missouri");
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
                    WriteLine("What is the capital of ​​the United Arab Emirates?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Abu Dhabi");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Ajman");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Kazajistan");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Dubai");
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
                    WriteLine("What is the smallest country in the world?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Andorra");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Luxembourg");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Vatican City");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Belgium");
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
                    WriteLine("How many countries are there in the world?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 192");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 145");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 195");
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
                    WriteLine("What is the longest river in the world;:");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) The Nile");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Yellow River");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) The Yangtze River");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Amazon River");
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
                    WriteLine("What is the capital of Australia?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Australia");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Canberra");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Zagreb");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Minsk");
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
                    WriteLine("What is the main language of Cuba??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) English");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Portuguese");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) African");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Spanish");
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
                    WriteLine("Which of these countries has the largest population?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Iran");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Germany");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Russia");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Brazil");
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
                    WriteLine("Which of these countries is in Africa?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Sudan");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Ecuador");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Haiti");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Buthan");
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
                    WriteLine("Which of these countries has a king? ");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Mexico");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Jordan");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Egypt");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Italia");
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
                    WriteLine("What is the capital of Ivory Coast?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Doha");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Dakar");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Yamusukro");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Bamaco");
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
                    WriteLine("What is the capital of Burkina Fasso?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Kuala Lumpur");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Nom Pem");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Burkina Fasso");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Uagadugu");
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
                    WriteLine("What is the capital of Ecuador?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Quito");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Guayaquil");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Lima");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Bogota");
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
