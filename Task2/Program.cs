using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option: ");
            Console.WriteLine("1.Launch and wait for child process");
            Console.WriteLine("2.Launch and kill child process");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Error. Enter choice correctly");
                return;
            }

            switch (choice)
            {
                case 1:
                    LaunchAndWaitForChildProcess();
                    break;
                case 2:
                    LaunchAndKillChildProcess();
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }

        static void LaunchAndWaitForChildProcess()
        {
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = "notepad.exe";
            childProcess.Start();

            childProcess.WaitForExit();

            Console.WriteLine($"Child process was ended with exit code: {childProcess.ExitCode}");
        }

        static void LaunchAndKillChildProcess()
        {
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = "notepad.exe";
            childProcess.Start();

            Console.WriteLine("Wait 3 seconds until killing child process");
            Thread.Sleep(3000);

            if (!childProcess.HasExited)
            {
                childProcess.Kill();
                Console.WriteLine("Child process was ended");
            }
        }
    }
}
