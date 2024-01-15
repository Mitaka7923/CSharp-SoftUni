using System.Numerics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());
            var totalPrice = 0M;
            var ordersPrice = new decimal[ordersCount];

            for (int i = 0; i <= ordersCount - 1; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsuleCount = int.Parse(Console.ReadLine());

                ordersPrice[i] = (days * capsuleCount) * capsulePrice;
                totalPrice += ordersPrice[i];
            }

            for (int i = 0; i < ordersPrice.Length; i++)
            {
                Console.WriteLine($"The price for the coffee is: ${ordersPrice[i]:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
