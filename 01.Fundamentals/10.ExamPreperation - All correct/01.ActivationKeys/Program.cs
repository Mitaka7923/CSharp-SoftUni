using System;
using System.Text;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var greet = "Hello world";
            Console.WriteLine(greet.Substring(3,4));
        }
    }
}

/*
 var rawActivationKey = Console.ReadLine();
            var activationKey = new StringBuilder(rawActivationKey);

            var command = string.Empty;
            while((command = Console.ReadLine()) != "Generate")
            {
                var tokens = command.Split(">>>");

                switch (tokens[0])
                {
                    case "Contains":
                        if (activationKey.ToString().Contains(tokens[1]))
                        {
                            Console.WriteLine($"{activationKey} contains {tokens[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        var startIndex = int.Parse(tokens[2]);
                        var length = int.Parse(tokens[3]) - startIndex;
                        var substring = activationKey.ToString().Substring(startIndex, length);
                        activationKey.Remove(startIndex, length);
                         
                        if (tokens[1] == "Upper")
                        {    
                            activationKey.Insert(startIndex, substring.ToUpper());
                        }
                        else
                        {
                            activationKey.Insert(startIndex, substring.ToLower());
                        }

                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        var start = int.Parse(tokens[1]);
                        activationKey.Remove(start, int.Parse(tokens[2]) - start);
                        Console.WriteLine(activationKey);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
 */