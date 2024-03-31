using System.Globalization;
using System.Text;

namespace _01.Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialUsername = Console.ReadLine();
            var username = initialUsername;
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "Registration")
            {
                var tokens = command.Split();

                switch (tokens[0])
                {
                    case "Letters":
                        var helper = username;
                        username = (tokens[1] == "Lower") ? helper.ToLower() : helper.ToUpper();
                        
                        break;
                    case "Reverse":
                        var startIndex = int.Parse(tokens[1]);
                        var endIndex = int.Parse(tokens[2]);

                        if (startIndex >= 0 && startIndex <= username.Length - 2 &&
                            endIndex > startIndex && endIndex <= username.Length - 1)
                        {
                            var substring = username.Substring(startIndex, endIndex - startIndex + 1).ToArray();
                            Array.Reverse(substring);
                            var reversed = new string(substring);
                            Console.WriteLine(reversed);
                        }

                        continue;
                    case "Substring":
                        if (username.Contains(tokens[1]))
                        {
                            var newUN = username.Remove(username.ToString().IndexOf(tokens[1]), tokens[1].Length);
                            username = newUN;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"The username {username} doesn't contain {tokens[1]}.");
                        }
                        continue;
                    case "Replace":
                        username = username.Replace(Convert.ToChar(tokens[1]), '-');
                        break;
                    case "IsValid":
                        if (username.Contains(Convert.ToChar(tokens[1])))
                        {
                            Console.WriteLine("Valid username.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{Convert.ToChar(tokens[1])} must be contained in your username.");
                            continue;
                        }
                }

                Console.WriteLine(username);
            }
        }
    }
}
