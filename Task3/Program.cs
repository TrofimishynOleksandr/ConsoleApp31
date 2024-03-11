using System.Diagnostics;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operation;
            string value;

            do
            {
                Console.Write("Enter number 1: ");
                value = Console.ReadLine();
            } while (!int.TryParse(value, out num1));

            do
            {
                Console.Write("Enter number 2: ");
                value = Console.ReadLine();
            } while (!int.TryParse(value, out num2));

            do
            {
                Console.Write("Enter operation: ");
                value = Console.ReadLine();
            } while (!char.TryParse(value, out operation));

            LaunchChildProcess(num1, num2, operation);
        }

        static void LaunchChildProcess(int num1, int num2, char operation)
        {
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = "C:\\Users\\User\\source\\repos\\ConsoleApp31\\Task3.1\\bin\\Debug\\net6.0\\Task3.1.exe";
            childProcess.StartInfo.Arguments = $"{num1} {num2} {operation}";
            childProcess.Start();
            childProcess.WaitForExit();
        }
    }
}
