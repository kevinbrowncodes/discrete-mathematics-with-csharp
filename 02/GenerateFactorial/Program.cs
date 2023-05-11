namespace GenerateFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, factorial;

            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt16(Console.ReadLine());

            factorial = num;

            for (i = num - 1; i >= 1; i--) 
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"\n{num}! = {factorial}");
        }
    }
}