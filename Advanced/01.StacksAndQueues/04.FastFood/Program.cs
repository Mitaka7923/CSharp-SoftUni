namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = new Queue<int>();
            var foodQuantityForDay = int.Parse(Console.ReadLine());
            var inputOrders = Console.ReadLine().Split().Select(int.Parse);
            
            foreach (var order in inputOrders)
            {
                orders.Enqueue(order);
            }

            Console.WriteLine(orders.OrderByDescending(x => x).First());
            while (orders.Count > 0)
            {
                if (orders.Peek() > foodQuantityForDay)
                {
                    break;
                }
                else
                {
                    foodQuantityForDay -= orders.Dequeue();
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }
        }
    }
}
