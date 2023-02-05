namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
        }


        static int VowelsCount(string input)
        {
            int count = 0;
            foreach (var charecter in input) 
            {
                if (ISVower(charecter))
                {
                    count++;
                }
            }
            return count;
        }

        static bool ISVower(char charecter)
        {
            char[] vowels = new[] { 'a', 'o', 'e', 'i', 'u', 'y', 'A', 'O', 'E', 'I', 'U', 'Y'};
            return vowels.Contains(charecter);
        }
    }
}