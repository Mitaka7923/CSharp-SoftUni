using System;

namespace _07._Vending_machine
{
    class Program
    {
        static void Main(string[] args) 
        {
            var availableProducts = new Dictionary<string, decimal>()
            {
                { "Nuts", 2M },
                { "Water", 0.7M },
                { "Crisps", 1.5M },
                { "Soda", 0.8M },
                { "Coke", 1M }
            };

            var coins = GatherCoins();
            var products = GatherProducts(availableProducts);

            foreach (var product in products)
            {
                if (coins - product.Value >= 0M)
                {
                    coins -= product.Value;
                    Console.WriteLine($"Purchased {product.Key.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

            Console.WriteLine($"Change: {coins:f2}");
        }
        static Dictionary<string, decimal> GatherProducts(Dictionary<string, decimal> availableProducts)
        {
            var products = new Dictionary<string, decimal>();
            
            while (true)
            {
                var productInput = Console.ReadLine();
                if (availableProducts.ContainsKey(productInput))
                {
                    products.Add(productInput, availableProducts[productInput]);
                }
                else if (productInput.Equals("End"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            return products;
        }

        static bool IsCoinValid(decimal coin)
        {
            var validCoins = new List<decimal>() { 0.1M, 0.2M, 0.5M, 1M, 2M };

            if (validCoins.Contains(coin))
            {
                return true;
            }

            return false;
        }

        static decimal GatherCoins()
        {
            var coins = 0M;

            while (true)
            {
                var inputCoin = Console.ReadLine();
                if (inputCoin == "Start")
                {
                    break;
                }
                else
                {
                    if (IsCoinValid(Convert.ToDecimal(inputCoin)))
                    {
                        coins += Convert.ToDecimal(inputCoin);
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {inputCoin}");
                    }
                }
            }

            return coins;
        }
    }
}