using static System.Console;

namespace Pig_Latin
{
    internal class PigLatin
    {
        static void Main(string[] args)
        {
            string appName = "Pig Latin App";
            string appVersion = "1.0.0";
            string appAuthor = "Chuka Victor Ogbodo";
            WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            PigLatinConverter();
        }

        static void PigLatinConverter()
        {
            string firstLetter;
            string afterWord;
            string pigLatinWord = "";
            int j;

            WriteLine("Enter a word or sentence to convert into PigLatin");
            string newSentence = ReadLine();

            string[] text = newSentence.Split();

            foreach (string word in text)
            {
                afterWord = word.Substring(1);
                firstLetter = word.Substring(0, 1);
                j = newSentence.IndexOf(firstLetter);

                pigLatinWord = afterWord + firstLetter + "ay ";

                Write(pigLatinWord);
            }

            WriteLine("Press any key to convert back to sentence.");
            ReadKey(true);
            string reversedString = null;
            reversedString = (string)newSentence.Clone();
            WriteLine(reversedString);
        }
    }


}
