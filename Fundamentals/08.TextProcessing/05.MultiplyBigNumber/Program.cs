using System.Numerics;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bigNumber = BigInteger.Parse(Console.ReadLine());
            var multiplyBy = double.Parse(Console.ReadLine());

            var result = bigNumber * (BigInteger)multiplyBy;
            Console.WriteLine(result);
        }
    }
}
