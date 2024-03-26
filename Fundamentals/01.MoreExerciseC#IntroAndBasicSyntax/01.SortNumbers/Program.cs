namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            numbers = numbers.OrderByDescending(x => x).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
