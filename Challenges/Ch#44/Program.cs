// using System;
// using static Facilities;
// namespace MyApp // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             PerformAction();
//         }

//        static  async void PerformAction()
//         {
//             string word = User<string>.AskForValue("Word", DarkGreen);
//             DateTime start = DateTime.Now;
//             int attempts = await RandomlyRecreateAsync(word);
//             Console.WriteLine(attempts);
//             TimeSpan elapsed = DateTime.Now - start;
//             Console.WriteLine(elapsed);

//         }
//          static int RandomlyRecreate(string word)
//         {
//             int length = word.Length;
//             int attempts = 0;
//             string newWord = "";
//             while (newWord != word)
//             {
//                 newWord = "";
//                 Random random = new Random();
//                 for (int x = 0; x <= length; x++)
//                 {
//                     newWord += (char)('a' + random.Next(26));
//                 }
//                 attempts++;
//             }
//             return attempts;
//         }
//        static Task<int> RandomlyRecreateAsync(string word)
//         {
//             return Task.Run(() => RandomlyRecreate(word));
//         }

//     }
// }
Console.Write("Enter a word to randomly regenerate: ");
string? word = Console.ReadLine();

DateTime start = DateTime.Now;
int attempts = await RandomlyRecreateAsync(word);
Console.WriteLine(attempts);
TimeSpan elapsed = DateTime.Now - start;
Console.WriteLine(elapsed);

int RandomlyRecreate(string? word)
{
    if (word == null) return 0;

    Random random = new Random();

    string generated;
    int attempts = 0;
    do
    {
        attempts++;
        generated = "";
        for (int letter = 0; letter < word.Length; letter++)
            generated += (char)('a' + random.Next(26));
    } while (generated != word);

    return attempts;
}

Task<int> RandomlyRecreateAsync(string? word)
{
    return Task.Run(() => RandomlyRecreate(word));
}
