using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Order
    {
        public Dictionary<string, int> FurnitureBought { get; set; } = new Dictionary<string, int>();
        
        public decimal TotalPrice = 0;

        public Order() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var order = new Order();
            var pattern = @">>(?<name>\w+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            while ((input = Console.ReadLine()) != "Purchase")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var groups = match.Groups;

                    if (int.Parse(groups["quantity"].Value) > 0)
                    {
                        order.FurnitureBought.Add(groups["name"].Value, int.Parse(groups["quantity"].Value));
                        order.TotalPrice += decimal.Parse(groups["price"].Value) * int.Parse(groups["quantity"].Value);
                    }
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in order.FurnitureBought)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine($"Total money spend: {order.TotalPrice:f2}");
        }
    }
}
