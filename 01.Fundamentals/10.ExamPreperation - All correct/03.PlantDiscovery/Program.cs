namespace _03.PlantDiscovery
{
    internal class Plant
    {
        public string Name { get; set; }
        public string Rarity { get; set; }
        public List<double> Ratings { get; set; } = new();

        public Plant(string name, string rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
        }

        public override string ToString() => $"- {this.Name}; Rarity: {this.Rarity}; Rating: {(this.Ratings.Count == 0 ? 0 : this.Ratings.Average()):f2}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var plants = new List<Plant>();
            var plantCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < plantCount; i++)
            {
                var plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                var plant = plants.FirstOrDefault(x => x.Name == plantInfo[0]);

                if (plant != null)
                {
                    plant.Rarity = plantInfo[1];
                }
                else
                {
                    plants.Add(new Plant(plantInfo[0], plantInfo[1]));
                }
            }

            var command = string.Empty;
            while((command = Console.ReadLine()) != "Exhibition")
            {
                var commandInfo = command.Split(": ");
                var tokens = commandInfo[1].Split(" - ");
                var plant = plants.FirstOrDefault(x => x.Name == tokens[0]);

                if (plant != null)
                {
                    switch (commandInfo[0])
                    {
                        case "Rate": plant.Ratings.Add(double.Parse(tokens[1])); break;
                        case "Update": plant.Rarity = tokens[1]; break;
                        case "Reset": plant.Ratings.Clear(); break;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            plants.ForEach(plant => Console.WriteLine(plant.ToString()));
        }
    }
}
