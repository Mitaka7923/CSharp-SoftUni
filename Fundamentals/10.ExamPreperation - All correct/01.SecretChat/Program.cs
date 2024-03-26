using System.Text;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var concealedMessage = Console.ReadLine();
            var message = new StringBuilder(concealedMessage);

            var command = string.Empty;
            while((command = Console.ReadLine()) != "Reveal")
            {
                var tokens = command.Split(":|:");

                switch (tokens[0])
                {
                    case "InsertSpace":
                        message.Insert(int.Parse(tokens[1]), ' ');
                        break;
                    case "ChangeAll":
                        message.Replace(tokens[1], tokens[2]);
                        break;
                    case "Reverse":
                        if (message.ToString().Contains(tokens[1]))
                        {
                            message.Remove(message.ToString().IndexOf(tokens[1]), tokens[1].Length);
                            var reversed = tokens[1].ToCharArray();
                            Array.Reverse(reversed);
                            message.Append(new string(reversed));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
