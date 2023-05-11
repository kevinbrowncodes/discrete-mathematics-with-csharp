namespace BasicArithmeticOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operation;

            Console.WriteLine("\nEnter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter an operation: ");
            Console.WriteLine("--------------------");
            Console.WriteLine("Addition: +");
            Console.WriteLine("Subtraction: -");
            Console.WriteLine("Multiplication: *");
            Console.WriteLine("Division: /");
            Console.WriteLine("--------------------");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"\n{num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"\n{num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"\n{num1} * {num2} = {result}");
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine($"\n{num1} / {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("\nInvalid Operation!");
                    break;
            }
        }
    }
}