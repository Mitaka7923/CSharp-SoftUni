namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            var querieCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < querieCount; i++)
            {
                var querie = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (querie[0] > 2 && stack.Count == 0)
                {
                    continue;
                }

                switch (querie[0])
                {
                    case 1:
                        stack.Push(querie[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.OrderByDescending(x => x).First());
                        break;
                    case 4:
                        Console.WriteLine(stack.OrderBy(x => x).First());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
