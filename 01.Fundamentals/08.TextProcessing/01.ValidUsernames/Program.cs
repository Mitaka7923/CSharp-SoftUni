using System.Diagnostics;
using System.Text;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (IsUsernameValid(username))
                    Console.WriteLine(username);
            }
        }

        internal static bool IsUsernameValid(string username)
        {
            if (username.Length > 3 && 
                username.Length < 16)
            {
                var letters = username.ToCharArray();

                foreach (var character in letters)
                {
                    if (!(char.IsLetter(character) || char.IsDigit(character) || character == '-' || character == '_'))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
