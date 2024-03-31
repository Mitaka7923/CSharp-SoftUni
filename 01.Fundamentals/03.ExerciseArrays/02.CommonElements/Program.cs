namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ');
            var secondArray = Console.ReadLine().Split(' ');

            var commonElements = new List<string>();

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray.Contains(secondArray[i]))
                {
                    commonElements.Add(secondArray[i]);
                }
            }

            Console.WriteLine(String.Join(' ', commonElements));
        }
    }
}
