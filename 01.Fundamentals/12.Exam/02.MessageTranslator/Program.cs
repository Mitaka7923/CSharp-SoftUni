// My exam problem

using System.Text.RegularExpressions;

namespace _02_MessageTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var command = Console.ReadLine();
                var match = Regex.Match(command, @"!(?<action>[A-Z][a-z]{2,})!:\[(?<string>[A-Za-z]{8,})\]");

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    var strChars = match.Groups["string"].Value.ToCharArray();
                    var strValues = new int[strChars.Length];
                    
                    for (int j = 0; j < strChars.Length; j++)
                    {
                        strValues[j] = Convert.ToInt32(strChars[j]);
                    }

                    var translatedCommand = $"{match.Groups["action"]}: {string.Join(' ', strValues)}";
                    Console.WriteLine(translatedCommand);
                }
            }
        }
    }
}
