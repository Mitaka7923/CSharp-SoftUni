using System.Text;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static string Reverse(string stringToReverse)
        {
            var charArray = stringToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            var pattern = @"(#|@)(?<word>[a-zA-Z]{3,})\1\1(?<mirroredWord>[a-zA-Z]{3,})\1";

            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            var mirroredWords = new Dictionary<string, string>();
            var wordPairCount = 0;

            foreach (Match match in matches)    
            {
                var reversedWord = Reverse(match.Groups["word"].Value);

                if (reversedWord == match.Groups["mirroredWord"].Value)
                    mirroredWords.Add(match.Groups["word"].Value, match.Groups["mirroredWord"].Value);
                
                wordPairCount++;
            }


            if (wordPairCount > 0)
                Console.WriteLine($"{wordPairCount} word pairs found!");
            else
                Console.WriteLine("No word pairs found!");
            if (mirroredWords.Any())
            {
                var words = new string[mirroredWords.Count];
                var count = 0;
                foreach (var word in mirroredWords)
                {
                    words[count++] = $"{word.Key} <=> {word.Value}";
                }

                Console.Write($"The mirror words are: \n{string.Join(", ", words)}");
            }
            else
                Console.WriteLine("No mirror words!");
        }
    }
}
