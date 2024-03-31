
namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var characterCount = new Dictionary<char, int>();
            var charactersAll = input.ToArray();

            for (int i = 0; i < charactersAll.Length; i++)
            {
                if (charactersAll[i] != ' ')
                {
                    if (!characterCount.ContainsKey(charactersAll[i]))
                        characterCount[charactersAll[i]] = 1;
                    else 
                        characterCount[charactersAll[i]]++;
                }
            }

            foreach (var character in characterCount)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
