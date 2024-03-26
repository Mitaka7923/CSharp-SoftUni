using System.Threading.Channels;

namespace SoftwareDevelopmentConcepts_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Dimitar\Desktop\Learning\CSharp-SoftUni\Fundamentals\SoftwareDevelopmentConcepts-2\notes.txt";
            
            var lines = File.ReadAllLines(path).ToList();
            var importantLines = new List<string?>();
            
            foreach (var line in lines)
            {
                if (line.StartsWith("!!!!"))
                    importantLines.Add(line.Substring(5));
            }

            lines.Clear();
            importantLines.ForEach(line => Console.WriteLine(line));
        }
    }
}
