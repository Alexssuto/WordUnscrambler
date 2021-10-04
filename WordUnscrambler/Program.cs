using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
            try
            {
                string input = " ";




                Console.WriteLine("Enter scrambled word(s) manually or as a file: F - file / M - manual");

                
                do
                {

                    String option = Console.ReadLine() ?? throw new Exception("String is empty");
                    switch (option.ToUpper())
                    {
                        case "F":
                            Console.WriteLine("Enter full path including the file name: ");
                            ExecuteScrambledWordsInFileScenario();
                            break;
                        case "M":
                            Console.WriteLine("Enter word(s) manually (separated by commas if multiple): ");
                            ExecuteScrambledWordsManualEntryScenario();
                            break;
                        default:
                            Console.WriteLine("Please enter F or M ");
                            break;
                    }
                } while (!input.ToUpper().Equals("F") && !input.ToUpper().Equals("M"));

                Console.ReadLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine("The program will be terminated." + ex.Message);

            }
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            var filename = Console.ReadLine();
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            var minput = Console.ReadLine() ?? string.Empty;

            string[] scrambledWords = minput.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);
        }


        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read(Constants.FILE);

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);
        }
    }
}
