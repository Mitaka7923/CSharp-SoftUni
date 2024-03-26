namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letterCount = int.Parse(Console.ReadLine());
            var startChar = 97;
            var endChar = startChar + letterCount;

            for (int firstChar = startChar; firstChar < endChar; firstChar++)
            {
                for (int secondChar = startChar; secondChar < endChar; secondChar++)
                {
                    for (int thirdChar = startChar; thirdChar < endChar; thirdChar++)
                    {
                        Console.WriteLine($"{(char)firstChar}{(char)secondChar}{(char)thirdChar}");
                    }
                }
            }
        }
    }
}
