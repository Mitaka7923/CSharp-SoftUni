namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamesPriceDictionary = new Dictionary<string, decimal>()
            {
                { "OutFall 4", 39.99M },
                { "CS: OG", 15.99M },
                { "Zplinter Zell", 19.99M },
                { "Honored 2", 59.99M },
                { "RoverWatch", 29.99M },
                { "RoverWatch Origins Edition", 39.99M },
            };

            var initialBalance = decimal.Parse(Console.ReadLine());
            var balance = initialBalance;

            while (true)
            {
                var gameName = Console.ReadLine();
                if (gameName.Equals("Game Time"))
                {
                    Console.WriteLine($"Total spent: ${initialBalance - balance:f2}. Remaining: ${balance:f2}");
                    break;
                }

                if (gamesPriceDictionary.ContainsKey(gameName)) 
                {
                    if (balance - gamesPriceDictionary[gameName] >= 0)
                    {
                        balance -= gamesPriceDictionary[gameName];
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
