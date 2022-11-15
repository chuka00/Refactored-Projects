using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
class NumberGuesser
{
    static void Main(string[] args)
    {
        string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Chuka Victor Ogbodo";

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        Console.ResetColor();

        int numberOfTries = 5;


        Random generatedSecretNum = new Random();
        int secretNumber = generatedSecretNum.Next(1, 100);



        while (true)
        {
            //Print the message to the user
            WriteLine($"Please guess the number between 1 and 100 \nYou have {numberOfTries} tries: \n");

            //Collect input from user
            int input = Convert.ToInt32(ReadLine());

            //Check if user input is equal to secret number
            if (input == secretNumber)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine($"Congratulations, you are correct!, the secret number is {secretNumber}\n");
                ResetColor();
                break;
            }

            //Check if user input is greater than the secret number
            else if (input >= secretNumber)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Your guess is larger than secret number\n");
                ResetColor();
                numberOfTries--;
            }

            //Check if user input is lesser than the secret number
            else if (input <= secretNumber)
            {
                //Change the text color
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Your guess is smaller than the secret number\n");
                //Reset Text color
                ResetColor();
                numberOfTries--;

            }


            //Check if user has run out of chances
            if (numberOfTries == 0)
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("Sorry, you've run out of tries!");
                WriteLine("Thanks for playing!");
                ResetColor();
                break;
            }
        }
    }
}