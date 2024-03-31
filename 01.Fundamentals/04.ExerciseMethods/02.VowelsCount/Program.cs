namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var vowelsCount = GetVowelsCount(input);
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string str)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'f' };
            var vowelsCount = 0;

            foreach (var character in str)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            return vowelsCount;
        }
    }
}
