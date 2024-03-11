using System.Diagnostics;

namespace Task4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            string wordToSearch;

            Console.WriteLine("Enter file path: ");
            filePath = Console.ReadLine();
            Console.WriteLine("Enter word to search: ");
            wordToSearch = Console.ReadLine();

            LaunchChildProcess(filePath, wordToSearch);
        }

        static void LaunchChildProcess(string filePath, string wordToSearch)
        {
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = "C:\\Users\\User\\source\\repos\\ConsoleApp31\\Task4.2\\bin\\Debug\\net6.0\\Task4.2.exe";
            childProcess.StartInfo.Arguments = $"{filePath} {wordToSearch}";
            childProcess.Start();
            childProcess.WaitForExit();
        }
    }
}
