namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = Convert.ToChar(Console.ReadLine());
            var end = Convert.ToChar(Console.ReadLine());

            if (start > end)
            {
                for (int i = end - 1; i > start; i--)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
