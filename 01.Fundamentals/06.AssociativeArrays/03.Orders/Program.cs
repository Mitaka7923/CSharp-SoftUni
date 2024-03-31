using System.ComponentModel.DataAnnotations.Schema;

namespace _03.Orders
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Product>();
            var productPrices = new Dictionary<Product, decimal>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input.Trim().Equals("buy"))
                    break;

                var productData = input.Split(' ');
                if (products.ContainsKey(productData[0]))
                {
                    products[productData[0]].Price = decimal.Parse(productData[1]);
                    products[productData[0]].Quantity += int.Parse(productData[2]);
                }
                else
                {
                    products.Add(productData[0], new Product(productData[0], decimal.Parse(productData[1]), int.Parse(productData[2])));
                }
            }

            foreach (var prod in products)
            {
                productPrices.Add(prod.Value, prod.Value.Price * prod.Value.Quantity);
            }

            foreach (var prod in productPrices)
            {
                Console.WriteLine($"{prod.Key.Name} -> {prod.Value:f2}");
            }
        }
    }
}
