using System.ComponentModel.DataAnnotations;

namespace _03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, double[]>();

            var input = string.Empty;
            while((input = Console.ReadLine()) != "Sail")
            {
                var cityData = input.Split("||");
                if (cities.ContainsKey(cityData[0]))
                {
                    cities[cityData[0]][0] += double.Parse(cityData[1]);
                    cities[cityData[0]][1] += double.Parse(cityData[2]);
                }
                else
                {
                    cities.Add(cityData[0], new double[] { double.Parse(cityData[1]), double.Parse(cityData[2]) });
                }
            }

            var command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split("=>");
                switch (tokens[0])
                {
                    case "Plunder":
                        cities[tokens[1]][1] -= double.Parse(tokens[3]);
                        cities[tokens[1]][0] -= double.Parse(tokens[2]);
                        Console.WriteLine($"{tokens[1]} plundered! {tokens[3]} gold stolen, {tokens[2]} citizens killed.");

                        if (cities[tokens[1]][0] <= 0 || cities[tokens[1]][1] <= 0)
                        {
                            cities.Remove(tokens[1]);
                            Console.WriteLine($"{tokens[1]} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        var gold = double.Parse(tokens[2]);
                        if (0 < gold)
                        {
                            cities[tokens[1]][1] += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {tokens[1]} now has {cities[tokens[1]][1]} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        break;
                }
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
        }
    }
}
