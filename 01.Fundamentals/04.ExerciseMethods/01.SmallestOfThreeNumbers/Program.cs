using System.Collections.Generic;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(Smallest(numbers));
        }

        static int Smallest(List<int> numbers)
        {
            var smallest = Int32.MaxValue;

            numbers.ForEach((x) =>
            {
                if (x < smallest) smallest = x;
            });

            return smallest;
        }
    }
}
