using System;
using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = FirstMenu();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            int temperatureconverter = TemperatureMenu();
                            Console.Clear();
                            switch (temperatureconverter)
                            {
                                case 1:
                                    CelsiustoFahrenheit();
                                    break;
                                case 2:
                                    CelsiustoKelvin();
                                    break;
                                case 3:
                                    FarhenheittoCelcius();
                                    break;
                                case 4:
                                    FarhenheittoKelvin();
                                    break;
                                case 5:
                                    KelvintoFarhenheit();
                                    break;
                                case 6:
                                    KelvintoCelsius();
                                    break;
                            }
                            if (temperatureconverter == 7)
                                break;
                        }
                        break;
                    case 2:
            while (true)
                        {
                            int lengthconverter = LengthMenu();
                            Console.Clear();
                            switch (lengthconverter)
                            {
                                case 1:
                                    InchestoFeet();
                                    break;
                                case 2:
                                    InchestoYards();
                                    break;
                                case 3:
                                    FeetToInches();
                                    break;
                                case 4:
                                    FeetToYards();
                                    break;
                                case 5:
                                    YardsToInches();
                                    break;
                                case 6:
                                    YardsToFeet();
                                    break;
                            }
                            if (lengthconverter == 7)
                                break;
                        }
                        break;
                    case 3:
                    while (true)
                    {
                        int timeconverter = TimeMenu();
                         Console.Clear();
                            switch (timeconverter)
                            {
                                case 1:
                                    SecondsToMinutes();
                                    break;
                                case 2:
                                    SecondsToHours();
                                    break;
                                case 3:
                                    MinutesToHours();
                                    break;
                                case 4:
                                    MinutesToSeconds();
                                    break;
                                case 5:
                                    HoursToMinutes();
                                    break;
                                case 6:
                                    HourstoSeconds();
                                    break;
                            }
                            if (timeconverter == 7)
                        break;
                    }
                    break;
                }
                if (choice == 4)
                    break;
            }
        }
        static void SecondsToMinutes()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("1.- Seconds to Minutes");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTime("Seconds:");
                (float measurement, time unit) answer = ConvertSecondstoMinutes(prompt);
                WriteLine($"min: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }

        }
        static void SecondsToHours()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine("2.- Seconds to Hours");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTime("Seconds:");
                (float measurement, time unit) answer = ConvertSecondstoHours(prompt);
                WriteLine($"hrs: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void MinutesToHours()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("3.- Minutes to Hours");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTime("min:");
                (float measurement, time unit) answer = ConvertMinutestoHours(prompt);
                WriteLine($"hrs: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
         static void MinutesToSeconds()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("4.- Minutes to Seconds");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTime("min:");
                (float measurement, time unit) answer = ConvertMinutestoSeconds(prompt);
                WriteLine($"s: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void HoursToMinutes()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("5.- Hours to Minutes");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTime("hrs:");
                (float measurement, time unit) answer = ConvertHourstoMinutes(prompt);
                WriteLine($"m: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
         static void HourstoSeconds()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("6.- Hours to Seconds");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTime("hrs:");
                (float measurement, time unit) answer = ConvertHourstoSeconds(prompt);
                WriteLine($"s: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void InchestoFeet()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("1.- Inches to Feet");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueLength("in");
                (float measurement, length unit) answer = ConvertInchtoFeet(prompt);
                WriteLine($"ft: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void InchestoYards()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkYellow;
                WriteLine("2.- Inches to Yards");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueLength("in");
                (float measurement, length unit) answer = ConvertInchtoYard(prompt);
                WriteLine($"yd: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }

        }
        static void FeetToInches()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("3.- Feet to Inches");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueLength("ft");
                (float measurement, length unit) answer = ConvertFeettoInch(prompt);
                WriteLine($"in: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void FeetToYards()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("4.- Feet to Yards");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueLength("ft");
                (float measurement, length unit) answer = ConvertFeettoYard(prompt);
                WriteLine($"yd: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
          static void YardsToInches()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("5.- Yards to Inches");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueLength("yd");
                (float measurement, length unit) answer = ConvertYardtoInch(prompt);
                WriteLine($"in: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void YardsToFeet()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("6.- Yards to Feet");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueLength("yd");
                (float measurement, length unit) answer = ConvertYardtoFeet(prompt);
                WriteLine($"ft: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }

        static void CelsiustoFahrenheit()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("1.- Celsius to Farhenheit");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTemp("Celsius");
                (float measurement, temperature unit) answer = ConvertCelsiustoFahrenheit(prompt);
                WriteLine($"Temperature in F°: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }

        }
        static void CelsiustoKelvin()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkBlue;
                WriteLine("2.- Celsius to Kelvin");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTemp("Celsius");
                (float measurement, temperature unit) answer = ConvertCelsiustoKelvin(prompt);
                WriteLine($"Temperature in K: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }

        }
        static void FarhenheittoCelcius()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("3.- Farhenheit to Celsius");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTemp("Farhenheit");
                (float measurement, temperature unit) answer = ConvertFarhenheittoCelsius(prompt);
                WriteLine($"Temperature in C: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }

        }
        static void FarhenheittoKelvin()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("4.- Farhenheit to Kelvin");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTemp("Farhenheit");
                (float measurement, temperature unit) answer = ConvertFarhenheittoKelvin(prompt);
                WriteLine($"Temperature in K: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Console.Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void KelvintoFarhenheit()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("4.- Kelvin to Farhenheit");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTemp("Kelvin");
                (float measurement, temperature unit) answer = ConvertKelvintoFarhenheit(prompt);
                WriteLine($"Temperature in F: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Console.Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static void KelvintoCelsius()
        {
            while (true)
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("4.- Kelvin to Celsius");
                ForegroundColor = ConsoleColor.White;
                float prompt = AskForaValueTemp("Kelvin");
                (float measurement, temperature unit) answer = ConvertKelvintoCelsius(prompt);
                WriteLine($"Temperature in C: {answer.measurement} {answer.unit}");
                string askTocontinue = AskTocontinue();
                if (askTocontinue == "yes" || askTocontinue == "Yes")
                {
                    Console.Clear();
                    continue;
                }
                else if (askTocontinue == "exit" || askTocontinue == "Exit")
                {
                    break;
                }
            }
        }
        static string AskTocontinue()
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine("Type 'Exit' if you want to go back to the menu or type 'Yes' if you want to continue in this section");
                    ForegroundColor = ConsoleColor.White;
                    Write("Do you wish to continue?: ");
                    string? answer = ReadLine();
                    if (answer == "Exit" || answer == "exit" || answer == "Yes" || answer == "yes")
                    {
                        return answer;
                    }
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not valid. Try again");
                        continue;
                    }
                }

                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not valid. Try again");
                }

            }


        }
        static float AskForaValueTemp(string temp)
        {
            while (true)
            {
                try
                {
                    Write($"Temperature in {temp}: ");
                    float prompt = Convert.ToSingle(ReadLine());
                    return prompt;
                }
                catch
                {
                    Console.Clear();
                    WriteLine("That is not valid. Try again");
                }
            }
        }
        static float AskForaValueLength(string length)
        {
            while (true)
            {
                try
                {
                    Write($"{length}: ");
                    float prompt = Convert.ToSingle(ReadLine());
                    return prompt;
                }
                catch
                {
                    Console.Clear();
                    WriteLine("That is not valid. Try again");
                }
            }
        }
        static float AskForaValueTime(string time)
        {
            while (true)
            {
                try
                {
                    Write($"{time}: ");
                    float prompt = Convert.ToSingle(ReadLine());
                    return prompt;
                }
                catch
                {
                    Console.Clear();
                    WriteLine("That is not valid. Try again");
                }
            }
        }
        static int FirstMenu()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"CONVERSION MENU", 20);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("1.- Temperature Converter");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"2.- Length Converter");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine($"3.- Time Converter");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    WriteLine("4.- Exit");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the action you would like to make: ");
                    Write("What conversion you would like to make?: ");
                    int prompt = Convert.ToInt32(ReadLine());
                    if (prompt == 1 || prompt == 2 || prompt == 3 || prompt == 4)
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
        static int TemperatureMenu()
        {
            while (true)
            {

                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("TEMPERATURE CONVERTER");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("1.- Celsius to Farhenheit");
                    WriteLine("2.- Celsius to Kelvin");
                    WriteLine("3.- Farhenheit to Celcius");
                    WriteLine("4.- Farhenheit to Kelvin");
                    WriteLine("5.- Kelvin to Farhenheit");
                    WriteLine("6.- Kelvin to Celcius");
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("7.- BACK");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the action you would like to do.");
                    Write("What conversion you would like to make?: ");
                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6 || choice == 7)
                        return choice;
                    else
                    {
                        Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteLine("That was not in the option. TRY AGAIN");
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("That was not in the options, TRY AGAIN");
                }
            }
        }

        static int LengthMenu()
        {
            while (true)
            {

                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("LENGTH CONVERTER");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("1.- Inches to Feet");
                    WriteLine("2.- Inches to Yard");
                    WriteLine("3.- Feet to Inches");
                    WriteLine("4.- Feet to Yards");
                    WriteLine("5.- Yards to Inches");
                    WriteLine("6.- Yards to Feet");
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("7.- BACK");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the action you would like to do.");
                    Write("What conversion you would like to make?: ");
                    int choice = Convert.ToInt32(ReadLine());
                    return choice;
                }
                catch
                {
                    WriteLine("That is not in the options, try again");
                }
            }

        }
        static int TimeMenu()
        {
            while (true)
            {

                try
                {
                    Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("TIME CONVERTER");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("1.- Seconds to Minutes");
                    WriteLine("2.- Seconds to Hours");
                    WriteLine("3.- Minutes to Hours");
                    WriteLine("4.- Minutes to Seconds");
                    WriteLine("5.- Hours to Minutes");
                    WriteLine("6.- Hours to Seconds");
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("7.- BACK");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine("Put the number of the action you would like to do.");
                    Write("What conversion you would like to make?: ");
                    int choice = Convert.ToInt32(ReadLine());
                    return choice;
                }
                catch
                {
                    WriteLine("That is not in the options, try again");
                }
            }
        }

        static (float measurement, temperature unit) ConvertCelsiustoFahrenheit(float number)
        {
            float measurement = (number * 1.8f) + 32;
            return (measurement, temperature.Farhenheit);
        }
        static (float measurement, temperature) ConvertCelsiustoKelvin(float number)
        {
            float measurement = number + 273.15f;
            return (measurement, temperature.Kelvin);

        }
        static (float measurement, temperature) ConvertFarhenheittoCelsius(float number)
        {
            float measurement = (number - 32) * 0.555555f;
            return (measurement, temperature.Celsius);
        }
        static (float measurement, temperature) ConvertKelvintoCelsius(float number)
        {
            float measurement = number-273.15f;
            return (measurement, temperature.Celsius);

        }
        static (float measurement, temperature) ConvertFarhenheittoKelvin(float number)
        {
            float measurement = ((number - 32) * 0.55555f) + 273.15f;
            return (measurement, temperature.Kelvin);
        }
        static (float measurement, temperature) ConvertKelvintoFarhenheit(float number)
        {
            float measurement = ((number - 273.15f) * 1.8f) + 32;
            return (measurement, temperature.Farhenheit);
        }



        static (float measurement, length) ConvertInchtoFeet(float number)
        {
            float measurement = number * 0.083f;
            return (measurement, length.feet);
        }
        static (float measurement, length) ConvertFeettoInch(float number)
        {
            float measurement = number / 0.083f;
            return (measurement, length.inches);
        }
        static (float measurement, length) ConvertInchtoYard(float number)
        {
            float measurement = number / 36;
            return (measurement, length.yards);
        }
        static (float measurement, length) ConvertYardtoInch(float number)
        {
            float measurement = number * 36;
            return (measurement, length.inches);
        }
        static (float measurement, length) ConvertYardtoFeet(float number)
        {
            float measurement = number * 3;
            return (measurement, length.feet);
        }
        static (float measurement, length) ConvertFeettoYard(float number)
        {
            float measurement = number / 3;
            return (measurement, length.yards);
        }


        static (float measurement, time) ConvertHourstoMinutes(float number)
        {
            float measurement = number * 60;
            return (measurement, time.minutes);
        }
        static (float measurement, time) ConvertHourstoSeconds(float number)
        {
            float measurement = number * 3600;
            return (measurement, time.seconds);
        }
        static (float measurement, time) ConvertMinutestoSeconds(float number)
        {
            float measurement = number * 60;
            return (measurement, time.seconds);
        }
        static (float measurement, time) ConvertSecondstoMinutes(float number)
        {
            float measurement = number / 60;
            return (measurement, time.minutes);
        }
        static (float measurement, time) ConvertMinutestoHours(float number)
        {
            float measurement = number / 60;
            return (measurement, time.hours);
        }
        static (float measurement, time) ConvertSecondstoHours(float number)
        {
            float measurement = number / 3600;
            return (measurement, time.hours);
        }

        enum temperature
        {
            Celsius, Farhenheit, Kelvin
        }
        enum length
        {
            inches, feet, yards
        }
        enum time
        {
            seconds, minutes, hours
        }
    }
}
