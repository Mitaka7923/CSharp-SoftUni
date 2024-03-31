using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1 && 
                    (i == 0 || input[i] != input[i - 1]))
                    output.Append(input[i]);
                else if (input[i] != input[i - 1])
                    output.Append(input[i]);
            }

            Console.WriteLine(output);
        }
    }
}
