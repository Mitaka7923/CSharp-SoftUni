namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());

            var firstArray = new int[inputCount];
            var secondArray = new int[inputCount];

            for (int i = 0; i < inputCount; i++)
            {
                var input = Console.ReadLine().Split(' ');

                firstArray[i] = int.Parse(input[(i % 2 != 0) ? 1 : 0]); // Using a ternary operator to eliminate reduntant code.
                secondArray[i] = int.Parse(input[(i % 2 != 0) ? 0 : 1]);
            }

            Console.WriteLine(String.Join(' ', firstArray));
            Console.WriteLine(String.Join(' ', secondArray));
        }
    }
}
