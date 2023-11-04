using System;
using static System.Console;
using static System.ConsoleColor;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class HangMan
    {
        static void Main(string[] args)
        {
            Clear();
            Game game = new Game();
        }

    }

    public class Game
    {
        public SelectedWord SelectedWord { get; set; }

        public int NumberOfGuesses { get; set; }

        public int RemainingTries { get; set; }

        public string IncorrectGuesses { get; set; }

        public List<char> GuessedLetters { get; set; }

        public int CorrectGuesses { get; set; }

        public Game(SelectedWord selectedWord)
        {
            SelectedWord = selectedWord;
            NumberOfGuesses = 0;
            RemainingTries = 7;
            IncorrectGuesses = "";
            GuessedLetters = new List<char>();
            DisplayGame();
        }
        public Game()
        {
            SelectedWord = new SelectedWord(AskForWord());
            NumberOfGuesses = 0;
            RemainingTries = 7;
            IncorrectGuesses = "";
            GuessedLetters = new List<char>();
            CorrectGuesses = 0;
            DisplayGame();
        }
        public string AskForWord()
        {
            while (true)
            {
                try
                {
                    ColorWrite("Word: ", Magenta);
                    string? word = ReadLine();
                    Clear();
                    return word;
                }
                catch
                {
                    Clear();
                    ColorWriteLine("That is not a valid word. TRY AGAIN", Red);
                }
            }
        }
        public void CheckForLetter(char a)
        {
            bool atLeastOneGuessedLetter = false;
            NumberOfGuesses++;
            GuessedLetters.Add(a);
            a = Char.ToUpper(a);

            for (int x = 0; x < SelectedWord.Word.Length; x++)
            {
                if (a == SelectedWord.Word[x])
                {
                    atLeastOneGuessedLetter = true;
                    SelectedWord.UnguessedWord[x] = a;
                    CorrectGuesses++;
                }
            }
            if (atLeastOneGuessedLetter == false)
            {
                IncorrectGuesses += $"{a} ";
                RemainingTries--;
            }
        }
        public void DisplayGame()
        {
            while (RemainingTries != 0)
            {
                try
                {

                    SelectedWord.DisplayUnGuessedWord();
                    DisplayRemaingTries();
                    DisplayIncorrectGuesses();
                    char letter = AskForLetter();
                    if (IsRepeatedLetter(letter)) throw new RepeatedLetterException();
                    CheckForLetter(letter);
                    if (CorrectGuesses == SelectedWord.Word.Length)
                    {
                        Win();
                        break;
                    }
                }
                catch (SystemException)
                {
                    ColorWriteLine("That is not a single letter. TRY AGAIN", Red);
                }
                catch (RepeatedLetterException)
                {
                    ColorWriteLine("That letter has already been guessed. TRY AGAIN", Red);
                }

            }
            if (RemainingTries == 0)
            {
                Lose();
            }



        }
        public void Win()
        {
            Clear();
            ColorWriteDescription("Word: ", SelectedWord.Word, Magenta);
            ColorWriteLine("Congratulations!. You have guessed the word", Green);
        }
        public void Lose()
        {

            Clear();
            ColorWriteDescription("Word: ", SelectedWord.Word, Magenta);
            ColorWriteLine("YOU HAVE BEEN HANGED! Try Again", Red);

        }
        public bool IsRepeatedLetter(char a)
        {

            if (GuessedLetters.Contains(a))
            {
                return true;
            }
            return false;

        }
        public void DisplayRemaingTries()
        {
            ColorWriteDescriptionAlignment("Remaining Tries: ", $"{RemainingTries}", Blue);
        }
        public void DisplayIncorrectGuesses()
        {
            ColorWriteDescriptionAlignment("Incorrect Guesses: ", $"{IncorrectGuesses}", DarkRed);
        }


        public char AskForLetter()
        {

            ColorWrite("Guess: ", Yellow);
            char letter = ToChar(ReadLine());
            return letter;

        }
    }

    public class RepeatedLetterException : System.Exception
    {
        public RepeatedLetterException() { }
        public RepeatedLetterException(string message) : base(message) { }
        public RepeatedLetterException(string message, System.Exception inner) : base(message, inner) { }
        protected RepeatedLetterException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class SelectedWord
    {

        public string? Word { get; }

        public char[]? ArrayOfRemainingLetters { get; set; }
        public int Length { get; }

        public int NumberOfGuessedLetters { get; set; }

        public int NumberOfRemainingLetters { get; set; }

        public char[] UnguessedWord { get; set; }

        public SelectedWord(string word)
        {
            Word = word.ToUpper();
            Length = word.Length;
            NumberOfGuessedLetters = 0;
            NumberOfRemainingLetters = 0;
            UnguessedWord = new char[Length];
            ArrayOfRemainingLetters = new char[Length];

            for (int x = 0; x < UnguessedWord.Length; x++)
            {
                UnguessedWord[x] = '_';
                ArrayOfRemainingLetters[x] = Word[x];
            }
        }
        public void DisplayUnGuessedWord()
        {
            ColorWrite("Word: ", Green);
            for (int x = 0; x < UnguessedWord.Length; x++)
            {
                Write(UnguessedWord[x] + " ");
            }
            WriteAlignment(" ");

        }


        public void DisplayWord()
        {
            for (int x = 0; x < ArrayOfRemainingLetters.Length; x++)
            {
                WriteAlignment($"{ArrayOfRemainingLetters[x]}");
            }
        }


    }
}