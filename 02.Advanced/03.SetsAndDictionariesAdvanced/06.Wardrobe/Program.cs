using System.Text;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothesCount = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < clothesCount; i++)
            {
                var inputData = Console.ReadLine().Split(" -> ");
                var clothes = inputData[1].Split(',');

                if (!wardrobe.ContainsKey(inputData[0]))
                {
                    wardrobe[inputData[0]] = new Dictionary<string, int>();
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[inputData[0]].ContainsKey(item))
                    {
                        wardrobe[inputData[0]][item] = 0;
                    }

                    wardrobe[inputData[0]][item]++;
                }
            }

            var searchedItemDetails = Console.ReadLine().Split();
            foreach (var (color,items) in wardrobe)
            {
                var searchedColor = false;

                Console.WriteLine($"{color} clothes:");
                if (searchedItemDetails[0] == color)
                {
                    searchedColor = true;
                }
                foreach (var item in items)
                {
                    var output = new StringBuilder($"* {item.Key} - {item.Value}");
                    if (item.Key == searchedItemDetails[1])
                    {
                        output.Append($" (found!)");
                    }
                    Console.WriteLine(output);
                }
            }
        }
    }
}
