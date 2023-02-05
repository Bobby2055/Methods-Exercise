namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Factorial(first) / Factorial(second):F2}");
            
        }
        static double Factorial(double number)
        {
            if (number < 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}