// More excercises #1

namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();

            var line = string.Empty;
            while ((line = Console.ReadLine()) != "end of contests")
            {
                var tokens = line.Split(':');
                contests.Add(tokens[0], tokens[1]);
            }

            line = string.Empty;
            var candidates = new Dictionary<string, Dictionary<string, double>>();

            while ((line = Console.ReadLine()) != "end of submissions")
            {
                var tokens = line.Split("=>");
                if (contests.ContainsKey(tokens[0]) && contests[tokens[0]] == tokens[1])
                {
                    if (!candidates.ContainsKey(tokens[2]))
                        candidates[tokens[2]] = new Dictionary<string, double>();
                    else
                        candidates[tokens[2]].Add(tokens[0], double.Parse(tokens[3]));
                }
            }

            var bestStudent = candidates.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"Best candidate {bestStudent.Key} with total {bestStudent.Value} points.");

            Console.WriteLine("Ranking:");
            foreach (var kvp in candidates.OrderByDescending(x => x.Value).Skip(1))
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
