/*
4
123456 2147483647
5000000 -500000
97766554 97766554
9999999999 8888888888
 
 */

using System.Numerics;

namespace _02.FromLeftToRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linesCount = BigInteger.Parse(Console.ReadLine());
            var outputs = new List<BigInteger>();

            for (int i = 1; i <= linesCount; i++)
            {
                var input = Console.ReadLine();
                var numbers = input.Split(' ');

                if (BigInteger.Parse(numbers[0]) > BigInteger.Parse(numbers[1]))
                {
                    outputs.Add(SumFromLeftToRight(numbers[0]));
                }
                else
                {
                    outputs.Add(SumFromLeftToRight(numbers[1]));
                }
            }

            outputs.ForEach(x => Console.WriteLine(x));
        }

        static BigInteger SumFromLeftToRight(string number)
        {
            BigInteger sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += BigInteger.Parse(number[i].ToString());
            }

            return sum;
        }
    }
}
