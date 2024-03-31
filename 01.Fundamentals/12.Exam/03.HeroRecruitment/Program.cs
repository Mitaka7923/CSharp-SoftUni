// My exam problem

namespace _03_HeroRecruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, List<string>>();

            var command = string.Empty;
            while((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();
                switch (tokens[0])
                {
                    case "Enroll":
                        if (!heroes.ContainsKey(tokens[1]))
                        {
                            heroes.Add(tokens[1], new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{tokens[1]} is already enrolled.");
                        }
                        break;
                    case "Learn":
                        if (!heroes.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"{tokens[1]} doesn't exist.");
                        }
                        else if (heroes[tokens[1]].Contains(tokens[2]))
                        {
                            Console.WriteLine($"{tokens[1]} has already learnt {tokens[2]}.");
                        }
                        else
                        {
                            heroes[tokens[1]].Add(tokens[2]);
                        }
                        break;
                    case "Unlearn":
                        if (!heroes.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"{tokens[1]} doesn't exist.");
                        }
                        else if (!heroes[tokens[1]].Contains(tokens[2]))
                        {
                            Console.WriteLine($"{tokens[1]} doesn't know {tokens[2]}.");
                        }
                        else
                        {
                            heroes[tokens[1]].Remove(tokens[2]);
                        }
                        break;
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
