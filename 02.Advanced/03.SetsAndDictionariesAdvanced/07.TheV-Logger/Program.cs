using System.Collections;

namespace _07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, HashSet<string>[]>();

            var command = Console.ReadLine().Split();
            while (command[0] != "Statistics")
            {
                if (command[1] == "joined" && !vloggers.ContainsKey(command[0]))
                {   
                    vloggers.Add(command[0], new HashSet<string>[2]);
                    vloggers[command[0]][0] = new HashSet<string>();
                    vloggers[command[0]][1] = new HashSet<string>();
                }
                else if (command[1] == "followed" && 
                    vloggers.ContainsKey(command[0]) && 
                    vloggers.ContainsKey(command[2]) && 
                    command[2] != command[0])
                {
                    vloggers[command[0]][1].Add(command[2]);
                    vloggers[command[2]][0].Add(command[0]);
                }

                command = Console.ReadLine().Split();
            }

            var mostFollowers = 0;
            var mostFamousVloggerData = vloggers.ElementAt(0);

            foreach (var vloggerData in vloggers)
            {
                if (vloggerData.Value[0].Count > mostFollowers || 
                    (vloggerData.Value[0].Count == mostFollowers && vloggerData.Value[1].Count < mostFamousVloggerData.Value[1].Count))
                {
                    mostFollowers = vloggerData.Value[0].Count;
                    mostFamousVloggerData = vloggerData;
                }
            }

            var count = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Console.WriteLine($"{count++}. {mostFamousVloggerData.Key} : {mostFamousVloggerData.Value[0].Count} followers, {mostFamousVloggerData.Value[1].Count} following");
            foreach (var follower in mostFamousVloggerData.Value[0].OrderBy(x => x))
            {
                Console.WriteLine($"*  {follower}");
            }
            
            foreach (var (vloggerName, vloggerData) in vloggers.OrderByDescending(x => x.Value[0].Count).ThenBy(x => x.Value[1].Count))
            {
                if (vloggerName != mostFamousVloggerData.Key)
                {
                    Console.WriteLine($"{count++}. {vloggerName} : {vloggerData[0].Count} followers, {vloggerData[1].Count} following");
                }
            }
        }
    }
}
