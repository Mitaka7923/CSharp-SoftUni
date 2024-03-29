namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var songs = new Queue<string>();
            var initialSongs = Console.ReadLine().Split(", ").ToArray();

            foreach (var song in initialSongs)
            {
                songs.Enqueue(song);
            }

            while (songs.Count > 0)
            {
                var command = Console.ReadLine();
                var tokens = command.Split();

                switch (tokens[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        var songToAdd = command.Substring(4);
                        if (!songs.Contains(songToAdd))
                        {
                            songs.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
