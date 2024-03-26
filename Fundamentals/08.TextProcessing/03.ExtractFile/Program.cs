using System.Diagnostics;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine().Trim();
            var file = path.Substring(path.LastIndexOf(@"\") + 1).Split('.');

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
