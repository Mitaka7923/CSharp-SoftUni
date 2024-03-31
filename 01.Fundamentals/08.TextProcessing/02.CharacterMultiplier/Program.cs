using System.Diagnostics.Metrics;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        internal static int SumStringValues(string x, string y)
        {
            var sum = 0;
            var shortestWord = x.Length <= y.Length ? x : y;
            var longestWord = shortestWord == x ? y : x;
            var lastIndex = shortestWord.Length - 1;

            for (int i = 0; i < shortestWord.Length; i++)
                sum += x[i] * y[i];

            if (x.Length != y.Length)
            {
                for (int i = 0; i < longestWord.Length - lastIndex - 1; i++)
                    sum += longestWord[lastIndex + i + 1];
            }

            return sum;
        }
        
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().Split(' ');
            var sumOfCharacters = SumStringValues(inputWords[0], inputWords[1]);

            Console.WriteLine(sumOfCharacters);
        }
    }
}
