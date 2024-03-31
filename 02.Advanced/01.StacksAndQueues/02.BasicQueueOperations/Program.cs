namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var contents = Console.ReadLine().Split().Select(int.Parse).ToList();

            var toEnqueueCount = tokens[0];
            var toDequeueCount = tokens[1];
            var toSearch = tokens[2];

            var queue = new Queue<int>();
            for (int i = 0; i < toEnqueueCount; i++)
            {
                queue.Enqueue(contents[i]);
            }

            for (int i = 0; i < toDequeueCount; i++)
            {
                queue.Dequeue();
            }

            foreach (var element in queue)
            {
                if (element == toSearch)
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.OrderBy(x => x).First());
            }
        }
    }
}
