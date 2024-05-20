namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uniqueElements = new HashSet<string>();
            var elementsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < elementsCount; i++)
            {
                var inputElements = Console.ReadLine().Split();
                foreach (var el in inputElements)
                {
                    uniqueElements.Add(el);
                }
            }

            uniqueElements = uniqueElements.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(' ', uniqueElements));
        }
    }
}
