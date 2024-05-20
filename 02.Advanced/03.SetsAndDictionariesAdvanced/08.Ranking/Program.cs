namespace CandidateRanking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestCredentials = new Dictionary<string, string>();
            var users = new Dictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input.Split(':');
                contestCredentials[tokens[0]] = tokens[1];
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                double points = double.Parse(tokens[3]);

                if (contestCredentials.ContainsKey(contest) && contestCredentials[contest] == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, double>();
                    }

                    if (!users[username].ContainsKey(contest) || users[username][contest] < points)
                    {
                        users[username][contest] = points;
                    }
                }
            }

            var bestUser = users.OrderByDescending(u => u.Value.Values.Sum()).First();
            var totalPoints = bestUser.Value.Values.Sum();
            Console.WriteLine($"Best candidate is {bestUser.Key} with total {totalPoints} points.");

            Console.WriteLine("Ranking:");
            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}