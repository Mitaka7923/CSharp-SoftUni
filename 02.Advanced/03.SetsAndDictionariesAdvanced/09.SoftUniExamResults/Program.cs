namespace _09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, double>>();
            var languages = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = input.Split('-');
                if (tokens.Contains("banned"))
                {
                    users.Remove(tokens[0]);
                    continue;
                }

                string username = tokens[0];
                string language = tokens[1];
                double points = double.Parse(tokens[2]);

                if (!languages.ContainsKey(language))
                {
                    languages.Add(language, 0);
                }
                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, double>());
                    users[username].Add(language, 0);
                }

                if (users[username].ContainsKey(language) && users[username][language] < points)
                {
                    users[username][language] = points;
                }
                
                languages[language]++;
            }

            Console.WriteLine("Results:");
            foreach (var user in users.OrderByDescending(x => x.Value.Sum(x => x.Value)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value.Sum(x => x.Value)}");
            }
            Console.WriteLine("Submissions:");
            foreach (var (language, usage) in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language} - {usage}");
            }
        }
    }
}