namespace _04.EvenTimes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, int>();
            var numbersCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < numbersCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            Console.WriteLine(numbers.First(kvp => kvp.Value % 2 == 0).Key);
        }
    }
}