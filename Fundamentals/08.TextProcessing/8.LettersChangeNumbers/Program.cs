using System.Runtime.CompilerServices;

namespace _8.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;

            foreach (var str in data)
            {
                char prefix = str[0], suffix = str[str.Length - 1];

                decimal score = int.Parse(str.Substring(1, str.Length - 2));
                if (char.IsUpper(prefix)) score /= prefix - 'A' + 1;
                else score *= prefix - 'a' + 1;

                if (char.IsUpper(suffix)) score -= suffix - 'A' + 1;
                else score += suffix - 'a' + 1;

                totalSum += score;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
