using System.Text;

namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stops = new StringBuilder(Console.ReadLine());
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "Travel")
            {
                var commandData = command.Split(':');
                switch (commandData[0])
                {
                    case "Add Stop":
                        var index = int.Parse(commandData[1]);
                        if (0 <= index && index <= stops.Length - 1)
                            stops.Insert(index, commandData[2]);
                        break;
                    case "Remove Stop":
                        var startIndex = int.Parse(commandData[1]);
                        var endIndex = int.Parse(commandData[2]);
                        if ((0 <= startIndex && startIndex <= stops.Length - 1) &&
                            (0 <= endIndex && endIndex <= stops.Length - 1))
                            stops.Remove(startIndex, endIndex - startIndex + 1);
                        break;
                    case "Switch": 
                        stops.Replace(commandData[1], commandData[2]); 
                        break;
                    default: break;
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}