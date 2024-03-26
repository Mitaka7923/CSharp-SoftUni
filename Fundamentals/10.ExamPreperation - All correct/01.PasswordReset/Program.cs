using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialPassword = Console.ReadLine();
            var encryptedPassword = initialPassword;
            var newRawPassword = new StringBuilder();
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                var tokens = command.Split(' ');

                switch (tokens[0])
                {
                    case "TakeOdd":
                        for (int i = 1; i < encryptedPassword.Length; i += 2)
                        {
                            newRawPassword.Append(encryptedPassword[i]);
                        }
                        encryptedPassword = newRawPassword.ToString();
                        break;
                    case "Cut":
                        encryptedPassword = encryptedPassword.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "Substitute":
                        if (encryptedPassword.Contains(tokens[1]))
                        {
                            encryptedPassword = encryptedPassword.Replace(tokens[1], tokens[2]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                            continue;
                        }
                }

                Console.WriteLine(encryptedPassword);
            }

            Console.WriteLine($"Your password is: {encryptedPassword}");
        }
    }
}
