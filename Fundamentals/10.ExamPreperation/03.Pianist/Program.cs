namespace _03.Pianist
{
    internal class Program
    {
        private static Dictionary<string, string[]> pieces = new();

        static void Main(string[] args)
        {
            var piecesCount = int.Parse(Console.ReadLine());
            InitatePieces(piecesCount);

            var command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
                ManipulatePieces(command);

            foreach (var piece in pieces)
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
        }

        private static void InitatePieces(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var pieceData = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                pieces.Add(pieceData[0], new string[] { pieceData[1], pieceData[2] });
            }
        }

        private static void ManipulatePieces(string command)
        {
            var tokens = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
            var piece = tokens[1];
            var composer = tokens[2];
            var key = tokens[3];

            switch (tokens[0])
            {
                case "Add":
                    if (pieces.ContainsKey(piece))
                        Console.WriteLine($"{piece} is already in the collection!");
                    else
                    {
                        pieces.Add(piece, new string[] { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    break;
                case "Remove":
                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        break;
                    }

                    pieces.Remove(piece);
                    Console.WriteLine($"Successfully removed {piece}!");
                    break;
                case "ChangeKey":
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][1] = tokens[2];
                        Console.WriteLine($"Changed the key of {piece} to {pieces[piece][1]}!");
                    }
                    else Console.WriteLine($"Invalid operation! {piece} does not exist in the collection."); break;
                default:
                    break;
            }
        }
    }
}