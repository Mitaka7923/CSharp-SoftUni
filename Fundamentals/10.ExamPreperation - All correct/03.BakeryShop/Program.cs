namespace _03.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = string.Empty;
            var food = new Dictionary<string, int>();
            var soldFood = 0;

            while((command = Console.ReadLine()) != "Complete")
            {
                var tokens = command.Split();
                var foodName = tokens[2];
                var quantity = int.Parse(tokens[1]);

                switch (tokens[0])
                {
                    case "Receive":
                        if (quantity > 0)
                        {
                            if (!food.ContainsKey(foodName))
                            {
                                food.Add(foodName, quantity);
                            }
                            else
                            {
                                food[foodName] += quantity;
                            }
                        }
                        break;
                    case "Sell":
                        if (!food.ContainsKey(foodName))
                        {
                            Console.WriteLine($"You do not have any {foodName}.");
                            break;
                        }
                        
                        food[foodName] -= quantity;
                        if (food[foodName] < 0)
                        {
                            Console.WriteLine($"There aren't enough {foodName}. You sold the last {quantity - Math.Abs(food[foodName])} of them.");
                            soldFood += quantity - Math.Abs(food[foodName]);
                            food.Remove(foodName);
                        }
                        else
                        {
                            Console.WriteLine($"You sold {quantity} {foodName}.");
                            if (food[foodName] == 0)
                            {
                                food.Remove(foodName);
                            }

                            soldFood += quantity;
                        }
                        break;
                }
            }

            foreach (var item in food)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine($"All sold: {soldFood} goods");
        }
    }
}
