// Mahri Gurbanova and Holida Annamuradova
// Lab13
// 12/01.2022

using System;
using System.IO;
using System.Text.RegularExpressions;


namespace Lab13Main
{
    public class Dictionary
    {
        static void Main(string[] args)
        {
            var path = "";

            if (args.Any())
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("No Files were found, please try again!");
                return;
            }
            string[] document;
            document = File.ReadAllLines(path);

            string [] dictionary = File.ReadAllLines("american-english.txt");
            int lineNumber = 1;
            int wordNumber = 1;
            foreach (var lineOfText in document)
            {
                var regexPattern = @"([^\W_]+[^\s,.':""\-\(\)\?!]*)";
                var words = Regex.Matches(lineOfText, regexPattern).Select(m => m.Value).ToArray();
                foreach (var word in words) //iteration words
                {
                    if (!dictionary.Contains(word.ToLower()))
                    {
                        Console.WriteLine($"'{word}' at line {lineNumber}, word {wordNumber} is not found.");
                    }

                    wordNumber++;
                }
                lineNumber++;

            }

        }

        public static string[] BreakUpLine(string lineOfText){
            var regexPattern = @"([^\W_]+[^\s,.:""\-\(\)\?!]*)";
            var words = Regex.Matches(lineOfText, regexPattern).Select(m => m.Value).ToArray();
            return words;
        } 
    }
}