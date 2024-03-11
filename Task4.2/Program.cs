using System.Text.RegularExpressions;

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("You need to enter 2 args: path and word to find");
                return;
            }

            string filePath = args[0];
            string wordToSearch = args[1];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File doesn't exist.");
                return;
            }

            int wordCount = CountWordOccurrences(filePath, wordToSearch);
            Console.WriteLine($"Word '{wordToSearch}' occurs in file {wordCount} times");
        }

        static int CountWordOccurrences(string filePath, string word)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count += Regex.Matches(line, @"\b" + word + @"\b").Count;
                }
            }
            return count;
        }
    }
}
