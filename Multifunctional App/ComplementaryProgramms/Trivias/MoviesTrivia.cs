using System;
using static System.Console;

namespace MoviesTrivia // Note: actual namespace depends on the project name.
{
    public class Movies
    {

        public static void MoviesTrivia(out int score, out int question, ref int HIGHSCORE)
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
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question3(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question4(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question5(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question6(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question7(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question8(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question9(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question10(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question11(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question12(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question13(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question14(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
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
                    WriteLine("What is the name of Harry Potter's villain?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Sauron");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Voldemort");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Dumbledore");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Darth Vader");
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
                    WriteLine("In The Matrix, which pill does Neo take?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Red pill");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Blue pill");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Both pills");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) He does not take any pill");
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
                    WriteLine("What is the name of the antagonist in the 'Scream' saga?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Chucky");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Leatherface");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Ghostface");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Sidney Prescott");
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
                    WriteLine("From which movie is the phrase: 'Look how they massacred my boy' from?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Men in Black");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Kingsman");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Paths of Glory");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The Godfather");
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
                    WriteLine("What 1994 crime film revitalized John Travolta's career??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Grease");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) The fanatic");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) The impostor");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Pulp Fiction");
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
                    WriteLine("Who was the antagonist besides Jason in Friday the 13th?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Pamela Vorhees (his mother)");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Freddy Krueger");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) There was no other antagonist");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Michael Vorhees (his father)");
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
                    WriteLine("Who played Batman in 1989?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Christian Bale");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) George Cloney");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Michael Kaeton");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Robert Pattinson");
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
                    WriteLine("Who has a purple lightsaber in Star Wars?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Yoda");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Mace Windu");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Luke Skywalker");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Han Solo");
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
                    WriteLine("Which Alfred Hitchcock thriller is notorious for its shocking 'shower scene'?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Psyco");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Halloween");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) The Birds");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The wizard of Oz");
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
                    WriteLine("What is the name of the enchanted hotel in'The Shinning'?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Overlook Hotel");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Overview Hotel");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Stanley Hotel");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Northview Hotel");
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
                    WriteLine("Which of this phrases is a Indiana Jone's quote: ?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Bees. Why did it have to be bees?");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Snakes. Why did it have to be snakes?");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) We always follow Maps To Buried Treasure");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) I love snakes as much as I love adventure");
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
                    WriteLine("Which actor hasn’t played the Joker?? ");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Heath Ledger");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Sean Penn");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Jared Letto");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Mark Hamill");
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
                    WriteLine("Which horror movie is this quote from: 'Sometimes, dead is better'?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) The silence of Lambs");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Nightmare on Elm Street");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Pet Sematary");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The night of the Living dead.");
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
                    WriteLine("What was in the box in Se7en??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) The hearth of Mill's (Brad Pitt) wife");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) A knife");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Mills's (Brad Pitt) wife's head");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Nothing");
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
                    WriteLine("Who plays old Magneto in the X-men saga?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Patrick Stewart");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Michael Fassbender");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Huge Jackman");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Ian McKellen");
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
