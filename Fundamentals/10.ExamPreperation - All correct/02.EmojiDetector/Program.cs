using System.Text;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var coolThreshHold = (long)1;

            foreach (var letter in text)
            {
                if (char.IsDigit(letter))
                {
                    coolThreshHold *= (int)char.GetNumericValue(letter);
                }
            }

            var emojis = new Dictionary<string[], double[]>();
            var matches = Regex.Matches(text, @"(?<symbols>:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1");
            
            foreach (Match match in matches )
            {
                var cool = 0.0;
                foreach (var letter in match.Groups["emoji"].Value)
                {
                    cool += letter;
                }

                emojis.Add(new string[] { match.Groups["emoji"].Value , match.Groups["symbols"].Value }, new double[] { cool, cool >= coolThreshHold ? 1 : 0});
            }

            Console.WriteLine($"Cool threshold: {coolThreshHold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in emojis)
            {
                if (emoji.Value[1] == 1)
                {
                    Console.WriteLine($"{emoji.Key[1]}{emoji.Key[0]}{emoji.Key[1]}");
                }
            }
            Console.WriteLine();
        }
    }
}
