namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("You need to enter 3 arguments: num1, num2 and operation (+, -, *, /)");
                return;
            }

            int num1, num2;
            if (!int.TryParse(args[0], out num1) || !int.TryParse(args[1], out num2))
            {
                Console.WriteLine("First two args have to be ints");
                return;
            }

            string operation = args[2];
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = (double)num1 / num2;
                    else
                        Console.WriteLine("Dividing by 0 is impossible");
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    return;
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
    }
}
