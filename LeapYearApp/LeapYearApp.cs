using static System.Console;
namespace LeapYearApp
{
    internal class LeapYearApp
    {
        static void Main(string[] args)
        {
            string appName = "Leap Year App";
            string appVersion = "1.0.0";
            string appAuthor = "Chuka Victor Ogbodo";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            LeapYearConverter();
        }

        static void LeapYearConverter()
        {
            int year = 0;
            int count = 0;
            Console.WriteLine("Kindly enter a year");

            year = Convert.ToInt32(ReadLine());


            if (year % 400 != 0 && year % 4 != 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("This is not a leap year, please try again!");
                ResetColor();
            }
            else
            {

                while (count < 20)
                {
                    if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                    {
                        ForegroundColor = ConsoleColor.DarkCyan;
                        WriteLine($"The next leap year is: " + year);
                        Console.ResetColor();
                        count++;
                    }

                    year++;
                }
            }
        }
        
    }
}