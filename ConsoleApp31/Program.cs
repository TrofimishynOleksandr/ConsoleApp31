using System.Diagnostics;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            process.StartInfo.FileName = "notepad.exe";

            try 
            { 
                process.Start();
            } 
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString()); 
            }

            Console.Write("Kill process?(y/n): ");

            var str = Console.ReadLine();

            if (str == "y") 
            { 
                process.Kill();
                process.WaitForExit();
                Console.WriteLine(process.ExitCode);
            }
        }
    }
}
