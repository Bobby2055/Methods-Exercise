namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!IsLenghtValid(password))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!OnlyContainsDigitsAndLetter(password))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            
            if (!ContainsAtLeast2Digits(password))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ContainsAtLeast2Digits(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }

        static bool OnlyContainsDigitsAndLetter(string password)
        {
            return password.All(char.IsLetterOrDigit);      
        }

        static bool IsLenghtValid(string password)
        {
            return password.Length > 6 && password.Length <= 10;
        }
    }
}