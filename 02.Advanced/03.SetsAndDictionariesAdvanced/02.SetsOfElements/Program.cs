namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();
            var uniqueNumbers = new HashSet<int>();

            for (int i = 0; i < lengths[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lengths[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num in set1)
            {
                if (set2.Contains(num))
                {
                    uniqueNumbers.Add(num);
                }
            }

            Console.WriteLine(string.Join(' ', uniqueNumbers));
        }
    }
}
