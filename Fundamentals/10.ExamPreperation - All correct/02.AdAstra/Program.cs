using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();
            var caloriesForDay = 2000.0;
            var totalCalories = 0.0;
            var food = new Dictionary<string[], double>();
            var matches = Regex.Matches(message, @"(#|\|)(?<itemName>[A-Za-z\s]+)\1(?<expDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1");
            
            foreach (Match match in matches )
            {
                food.Add(new string[] { match.Groups["itemName"].Value, match.Groups["expDate"].Value },
                    double.Parse(match.Groups["calories"].Value));
                totalCalories += double.Parse(match.Groups["calories"].Value);
            }

            var daysToLive = Math.Floor(totalCalories / caloriesForDay);
            
            Console.WriteLine($"You have food to last you for: {daysToLive} days!");
            foreach (var item in food)
            {
                Console.WriteLine($"Item: {item.Key[0]}, Best before: {item.Key[1]}, Nutrition: {item.Value}");
            }
        }
    }
}
