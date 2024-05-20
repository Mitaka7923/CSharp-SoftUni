namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usernamesCount = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < usernamesCount; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
