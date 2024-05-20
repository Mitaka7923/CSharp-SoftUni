using System.Text;

namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var board = new int[rows][];
            var activeCellsCount = 0;
            var sum = 0;
            var boardVisualiser = new StringBuilder();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                var rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                board[i] = rowData;
            }
            var bombLocations = new List<int[]>();
            Console.ReadLine().Split().ToList().ForEach(x => bombLocations.Add(x.Split(',').Select(int.Parse).ToArray()));

            for (int i = 0; i < bombLocations.Count; i++)
            {
                var coords = bombLocations[i];
                if (IsInside(board, coords[0], coords[1]))
                {
                    var power = board[coords[0]][coords[1]];
                    if (power < 0)
                    {
                        continue;
                    }

                    var positions = new int[]
                    {
                        coords[0] - 1, coords[1] -1,
                        coords[0] - 1, coords[1],
                        coords[0] - 1, coords[1] +1,
                        coords[0], coords[1] -1,
                        coords[0], coords[1] + 1,
                        coords[0] + 1, coords[1] -1,
                        coords[0] + 1, coords[1],
                        coords[0] + 1, coords[1] + 1,
                    };

                    for (int pos = 0; pos < positions.Length; pos += 2)
                    {
                        if (IsInside(board, positions[pos], positions[pos + 1]) && board[positions[pos]][positions[pos + 1]] > 0)
                        {
                            board[positions[pos]][positions[pos + 1]] -= power;
                        }
                    }
                }

                board[coords[0]][coords[1]] = 0;
            }

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] > 0)
                    {
                        activeCellsCount++;
                        sum += board[row][col];
                    }
                }
                boardVisualiser.AppendLine(string.Join(" ", board[row]));
            }

            Console.WriteLine($"Alive cells: {activeCellsCount}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine(boardVisualiser);
        }

        public static bool IsInside(int[][] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0)
                && col >= 0 && col < board[row].Length;
        }
    }
}
