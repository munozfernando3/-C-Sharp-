
using System;
public class MyApp
{
    public static void Main(string[] args)
    {
        const int result = 1000;

        string[] firstNameResult = new string[result];
        string[] middleNameResult = new string[result];
        string[] lastNameResult = new string[result];
        string[] jobResult = new string[result];
        decimal[] hourlyWageResult = new decimal[result];
        decimal[] yearlySalaryResult = new decimal[result];

        string[] MaleFirstNames = new string[10] { "Jack", "Charles", "James", "William", "John", "Rickard", "Andrew", "Alex", "Harry", "Roberth" };
        string[] MaleMiddleNames = new string[10] { "Henrry", "Mateo", "Daniel", "Owen", "Samuel", "Jacob", "Asher", "Joseph", "David", "Leo" };
        string[] FemaleFirstNames = new string[10] { "Anna", "Eva", "Lorraine", "Sophia", "Doris", "Mary", "Elizabeth", "Brienne", "Maya", "Alexia" };
        string[] FemaleMiddleNames = new string[10] { "Maeve", "Alice", "Ayleen", "Scarlett", "Diana", "Rose", "Arya", "Madison", "Willow", "Grace" };
        string[] LastNames = new string[10] { "Thompson", "Robinson", "Wittmark", "Brown", "Fox", "Wallace", "Nielsom", "Anderson", "Hills", "Garcia" };

        string[] job = new string[] { "Professor", "Singer", "Pianist", "Lawyer", "Software Engineer", "Doctor", "Waiter", "Accountant", "Chef", "Writer" };
        decimal[] hourlyWage = new decimal[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        decimal[] yearlySalary = new decimal[10];
        var random = new Random();
        for (int i = 0; i < result; i++)
        {
            string randomMaleFirstNames = MaleFirstNames[random.Next(MaleFirstNames.Length)];
            string randomMaleMiddleNames = MaleMiddleNames[random.Next(MaleMiddleNames.Length)];
            string randomLastNames = LastNames[random.Next(LastNames.Length)];
            while (!Name(randomMaleFirstNames, randomMaleMiddleNames, randomLastNames, firstNameResult, middleNameResult, lastNameResult, i))
            {
                randomMaleFirstNames = MaleFirstNames[random.Next(MaleFirstNames.Length)];
                randomMaleMiddleNames = MaleMiddleNames[random.Next(MaleMiddleNames.Length)];
                randomLastNames = LastNames[random.Next(LastNames.Length)];
            }
            firstNameResult[i] = randomMaleFirstNames;
            middleNameResult[i] = randomMaleMiddleNames;
            lastNameResult[i] = randomLastNames;
            jobResult[i] = job[random.Next(job.Length)];
            hourlyWageResult[i] = hourlyWage[random.Next(hourlyWage.Length)];

            i++;
            string randomFirstFemales = FemaleFirstNames[random.Next(FemaleFirstNames.Length)];
            string randomMiddleNameFemales = FemaleMiddleNames[random.Next(FemaleMiddleNames.Length)];
            randomLastNames = LastNames[random.Next(LastNames.Length)];

            while (!Name(randomFirstFemales, randomMiddleNameFemales, randomLastNames, firstNameResult, middleNameResult, lastNameResult, i))
            {
                randomFirstFemales = FemaleFirstNames[random.Next(FemaleFirstNames.Length)];
                randomMiddleNameFemales = FemaleMiddleNames[random.Next(FemaleMiddleNames.Length)];
                randomLastNames = LastNames[random.Next(LastNames.Length)];

            }

            firstNameResult[i] = randomFirstFemales;
            middleNameResult[i] = randomMiddleNameFemales;
            lastNameResult[i] = randomLastNames;
            jobResult[i] = job[random.Next(job.Length)];
            hourlyWageResult[i] = hourlyWage[random.Next(hourlyWage.Length)];
        }

        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(i+1+ ". "+firstNameResult[i] + " " + middleNameResult[i] + " " + lastNameResult[i] + " ");
            Console.WriteLine("Job: " + jobResult[i]);
            Console.WriteLine(hourlyWageResult[i] + " per hour.");
            Console.WriteLine(hourlyWageResult[i] * 40 * 50 + " per year");
            Console.WriteLine("------------------------------------------------------");
        }

    }
    private static bool Name(string first, string mid, string last, string[] firstresult, string[] midresult, string[] lastresult, int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (first == firstresult[i] && mid == midresult[i] && last == lastresult[i])
            {
                return false;
            }
        }
        return true;
    }
}   
            
            
            