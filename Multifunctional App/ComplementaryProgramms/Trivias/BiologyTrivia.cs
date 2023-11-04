using System;
using static System.Console;

namespace BiologyTrivia // Note: actual namespace depends on the project name.
{
    public class Biology
    {

        public static void BiologyTrivia(out int score, out int question, ref int HIGHSCORE)
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
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question3(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question4(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question5(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question6(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question7(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question8(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question9(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question10(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question11(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'a', ref question, ref score, ref life, ref exit);
                Question12(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'b', ref question, ref score, ref life, ref exit);
                Question13(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
                Question14(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'd', ref question, ref score, ref life, ref exit);
                Question15(ref answer, life, exit, score, question);
                CheckAnswer(answer, 'c', ref question, ref score, ref life, ref exit);
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
                    WriteLine("What does 'DNA' stand for?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Deoxyribonucleic acid");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Deribonucleic acid");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Deoxynucleic acid");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Deoxyribonuclear acid");
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
                    WriteLine("How many bones are there in an adult human body?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 206");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 72");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 150");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 172");
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
                    WriteLine("Botany is the study of?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Plants");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Animals");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Forests");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Flowers");
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
                    WriteLine("Which famous scientist introduced the idea of natural selection?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Gregor Mendel");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Charles Darwin");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Carlos Linneo");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Aristotele");
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
                    WriteLine("Photosynthesis generally takes place in which parts of the plant??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Bark and Leaf");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Stem and leaf");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Roots and chloroplast bearing parts");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Leaf and other chloroplast bearing parts");
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
                    WriteLine("Pigmentation of skin is due to");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) leucocytes");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) monocytes");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) melanocytes");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) lymphocytes");
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
                    WriteLine("Number of chromosomes in Down's syndrome is:");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 48");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 49");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 46 ");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 47");
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
                    WriteLine("Animals which eat both plants and other animals are known as what?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Oviparous");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Carnivores");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Herbivores");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Omnivores");
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
                    WriteLine("What is the biological name given to the group of organisms including mushrooms??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Algae");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Fungi");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Procariote");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Pteridophyta");
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
                    WriteLine("What organelle can be found in a plant cell but not an animal cell??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Chloroplast");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Cytoplasm");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Mitochondrion");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Cell Membrane");
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
                    WriteLine("Which of these organs is important in releasing digestive enzymes and insulin??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Pancreas");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Kidneys");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Lungs%");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) The hearth");
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
                    WriteLine("Which system of the body controls the senses? ");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Digestive system");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Nervous system");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Skeletal system");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Circulatory system");
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
                    WriteLine("Similar body cells group together to form a ___?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Organ");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Blood vessels");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Tissue");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Joints");
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
                    WriteLine("Which of the following is NOT a form of carbon?");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) Diamond");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) Graphite");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) Amorphous Carbon");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) Ferriet");
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
                    WriteLine("What is the boiling point of water??");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("a) 50°C");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("b) 75°C");
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("c) 100°C");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("d) 500°C");
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
