using static System.Console;
namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Program
    {
       public static void Main(string[] args)
        {
            Clear();
            RecentNumbers recentNumbers = new RecentNumbers(0, 9, 2);
            Thread tread = new Thread(GenerateNumbersPerSecond);
            tread.Start(recentNumbers);
            // while (true)
            // {
            //     Console.ReadKey(false);

            //     if(isDuplicate) Console.WriteLine("You found a duplicate!");
            //     else Console.WriteLine("That is not a duplicate.");
            // 
            while (true)
            {
                Console.ReadKey(false);
                lock (recentNumbers)
                if (recentNumbers.AreDuplicates()) Console.WriteLine("You found a duplicate!");
                else Console.WriteLine("That is not a duplicate.");
            }
        }
        public static void GenerateNumbersPerSecond(object o)
        {
            if (o == null || o is not RecentNumbers)
            {
                return;
            }
            RecentNumbers recentNumbers = (RecentNumbers)o;
            GenerateNumbers(recentNumbers);
            while (true)
            {
                GenerateNumbers(recentNumbers);
                Thread.Sleep(recentNumbers.Seconds);
            }
        }
        public static void GenerateNumbers(RecentNumbers recentNumbers)
        {
            Random randomNumber = new Random();
            int newNumber = randomNumber.Next(recentNumbers.Min, recentNumbers.Max + 1);
            WriteLine(newNumber);
            recentNumbers.generatedNumbers.Add(newNumber);
            lock (recentNumbers)
            {
                recentNumbers.Update();
            }
           

        }
    }
    }
    public class RecentNumbers
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public int MostRecentNumber { get; set; }
        public int MostSecondRecentNumber { get; set; }
        public int Seconds { get; }

        public List<int> generatedNumbers { get; set; }

        public RecentNumbers(int min, int max, int seconds)
        {
            generatedNumbers = new List<int>();
            Max = max;
            Min = min;
            Seconds = seconds * 1000;
        }
        public void Update()
        {
            if (generatedNumbers.Count >= 2)
            {
                MostRecentNumber = generatedNumbers[generatedNumbers.Count - 1];
                MostSecondRecentNumber = generatedNumbers[generatedNumbers.Count - 2];
            }
        }
        public bool AreDuplicates()
        {
            return MostRecentNumber == MostSecondRecentNumber;
        }
        public void PrintRecents()
        {
            WriteLine("Most Recent: " + MostRecentNumber + " Second most Recent: " + MostSecondRecentNumber);
        }
       

    }


// RecentNumbers recentNumbers = new RecentNumbers { MostRecent = -1, SecondMostRecent = -2 };
// Thread generatingThread = new Thread(GenerateNumbers);
// generatingThread.Start(recentNumbers);

// while (true)
// {
//     Console.ReadKey(false);

//     bool isDuplicate;
//     lock(recentNumbers)
//         isDuplicate = recentNumbers.MostRecent == recentNumbers.SecondMostRecent;

//     if(isDuplicate) Console.WriteLine("You found a duplicate!");
//     else Console.WriteLine("That is not a duplicate.");
// }

// void GenerateNumbers(object? o)
// {
//     if (o == null || o is not RecentNumbers) return; // Shouldn't ever happen, but worth checking anyway.

//     RecentNumbers recentNumbers = (RecentNumbers)o;
//     Random random = new Random();
//     while (true)
//     {
//         int nextNumber = random.Next(10);

//         lock (recentNumbers)
//         {
//             recentNumbers.SecondMostRecent = recentNumbers.MostRecent;
//             recentNumbers.MostRecent = nextNumber;
//         }

//         Console.WriteLine(nextNumber);
//         Thread.Sleep(1000);
//     }
// }

// public class RecentNumbers
// {
//     public int MostRecent { get; set; }
//     public int SecondMostRecent { get; set; }
// }