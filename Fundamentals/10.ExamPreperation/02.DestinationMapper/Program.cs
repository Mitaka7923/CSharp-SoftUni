using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var location = Console.ReadLine();
            var matches = Regex.Matches(location, @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1");
            var locations = matches.Select(x => x.Groups["location"].Value);
            var travelPoints = 0;

            foreach (var loc in locations)
                travelPoints += loc.Length;

            if (locations.Any()) 
                Console.WriteLine($"Destinations: {string.Join(", ", locations)}");
            else
                Console.WriteLine("Destinations:");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
