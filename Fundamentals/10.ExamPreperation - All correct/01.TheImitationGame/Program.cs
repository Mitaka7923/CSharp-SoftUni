using System.Text;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encryptedMessage = Console.ReadLine();
            var command = string.Empty;
            var message = new StringBuilder(encryptedMessage);

            while ((command = Console.ReadLine()) != "Decode")
            {
                var commandContents = command.Split('|');
                switch (commandContents[0])
                {
                    case "Move":
                        var letterCount = int.Parse(commandContents[1]);
                        message.Append(message.ToString().Substring(0, letterCount));
                        message.Remove(0, letterCount);
                        break;
                    case "Insert": message.Insert(int.Parse(commandContents[1]), commandContents[2]); break;
                    case "ChangeAll": message.Replace(commandContents[1], commandContents[2]); break;
                    default: break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
