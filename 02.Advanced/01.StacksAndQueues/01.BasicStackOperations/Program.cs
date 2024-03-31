using System.Text;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stackElements = Console.ReadLine().Split().Select(int.Parse).ToList();

            var elementsToPush = tokens[0];
            var elementsToPop = tokens[1];
            var searchedElement = tokens[2];

            var stack = new Stack<int>();
            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(stackElements[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            foreach (var item in stack)
            {
                if (item == searchedElement)
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.OrderBy(x => x).First());
            }
        }
    }
}
