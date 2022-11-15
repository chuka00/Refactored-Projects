using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearApp
{
    internal class LeapYear

        
        static void LeapYearConverter()
        {
            int year = 0;
            int count = 0;
            Console.WriteLine("Kindly enter a year");

            year = Convert.ToInt32(ReadLine());

            //check to see if the year entered is a leap year i.e 2000, 1700, 1800, 2020 etc
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
                        //print the next leap year message
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
