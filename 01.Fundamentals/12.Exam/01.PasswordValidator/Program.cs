// My exam problem

using System.Text;
using System.Text.RegularExpressions;

namespace _01_PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var passwordInput = Console.ReadLine();
            var manipulatedPassword = new StringBuilder(passwordInput);

            var command = string.Empty;
            while((command = Console.ReadLine()) != "Complete")
            {
                var tokens = command.Split();
                switch (tokens[0])
                {
                    case "Replace":
                        var oldChar = Convert.ToChar(tokens[1]);

                        if (manipulatedPassword.ToString().Contains(oldChar))
                        {
                            var newChar = Convert.ToChar(oldChar + int.Parse(tokens[2]));
                            manipulatedPassword.Replace(oldChar, newChar);
                        }
                        break;
                    case "Make":
                        var index = int.Parse(tokens[2]);
                        
                        if (tokens[1] == "Upper")
                        {
                            manipulatedPassword.Replace(manipulatedPassword[index], manipulatedPassword[index].ToString().ToUpper().ToCharArray()[0], index, 1);
                        }
                        else if (tokens[1] == "Lower")
                        {
                            manipulatedPassword.Replace(manipulatedPassword[index], manipulatedPassword[index].ToString().ToLower().ToCharArray()[0], index, 1);
                        }
                        break;
                    case "Insert":
                        var insertIndex = int.Parse(tokens[1]);
                        
                        if (insertIndex >= 0 && insertIndex <= manipulatedPassword.Length - 1)
                        {
                            manipulatedPassword.Insert(insertIndex, tokens[2]);
                        }

                        break;
                    case "Validation":
                        if (manipulatedPassword.Length < 8)
                        {
                            Console.WriteLine("Password must be at least 8 characters long!");
                        }
                        if (!Regex.IsMatch(manipulatedPassword.ToString(), @"^[A-Za-z0-9_]+$"))
                        {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                        }
                        if (!Regex.IsMatch(manipulatedPassword.ToString(), @"[A-Z]+"))
                        {
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                        }
                        if (!Regex.IsMatch(manipulatedPassword.ToString(), @"[a-z]+"))
                        {
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                        }
                        if (!Regex.IsMatch(manipulatedPassword.ToString(), @"\d+"))
                        {
                            Console.WriteLine("Password must consist at least one digit!");
                        }
                        continue;
                    default: continue;
                }

                Console.WriteLine(manipulatedPassword);
            }
        }
    }
}
