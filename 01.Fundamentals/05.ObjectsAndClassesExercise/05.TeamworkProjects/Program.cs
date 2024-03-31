using System.Runtime.InteropServices;

namespace _05.TeamworkProjects
{
    internal class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public string Member { get; set; }

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var teamsCount = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                var teamInfo = Console.ReadLine().Split('-');
                teams.Add(new Team(teamInfo[0], teamInfo[1]));
                Console.WriteLine($"Team {teamInfo[1]} has been created by {teamInfo[1]}!");
            }

            while (true)
            {
                var actionInfo = Console.ReadLine();
                if (actionInfo == "end of assignment")
                {
                    break;
                }

                var info = actionInfo.Split("->");
                foreach (var team in teams)
                {
                    if (team.Creator == info[0])
                    {
                        Console.WriteLine($"Member {team.Creator} cannot join {team.Name}!");
                    }
                    else
                    {
                        team.Member = info[0];
                    }
                }
            }

            foreach (var team in teams)
            {
                if (team.Member == )
                {

                }
            }
        }
    }
}
