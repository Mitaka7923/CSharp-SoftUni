namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var digits = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
            };

            var input = int.Parse(Console.ReadLine());
            var lastDigit = input % 10;

            Console.WriteLine(digits[lastDigit]);
        }
    }
}
