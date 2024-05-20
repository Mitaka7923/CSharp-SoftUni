namespace _09.Miner
{
    internal class Program
    {
        public static int[] minerPosition = new int[2];
        public static char[,] field;
        public static int coalCount = 0;
        public static int coalMinedCount = 0;

        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            field = new char[fieldSize, fieldSize];
            var commands = Console.ReadLine().Split();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row,col] = Convert.ToChar(rowData[col]);
                    if (field[row, col] == 's')
                    {
                        minerPosition[0] = row;
                        minerPosition[1] = col;
                    }
                    else if (field[row, col] == 'c')
                    {
                        coalCount++;
                    }
                }
            }

            foreach (var command in commands)
            {
                MoveMiner(command);
            }

            Console.WriteLine($"{coalCount - coalMinedCount} coals left. ({string.Join(", ", minerPosition)})");
        }

        public static char[,] MoveMiner(string direction)
        {
            switch (direction)
            {
                case "up":
                    if (IsInside(field, minerPosition[0] - 1, minerPosition[1]))
                    {
                        minerPosition[0]--;
                    }
                    break;
                case "left":
                    if (IsInside(field, minerPosition[0], minerPosition[1] - 1))
                    {
                        minerPosition[1]--;
                    }
                    break;
                case "right":
                    if (IsInside(field, minerPosition[0], minerPosition[1] + 1))
                    {
                        minerPosition[1]++;
                    }
                    break;
                case "down":
                    if (IsInside(field, minerPosition[0] + 1, minerPosition[1]))
                    {
                        minerPosition[0]++;
                    }
                    break;
            }

            var discoveredChar = field[minerPosition[0], minerPosition[1]];

            if (discoveredChar == 'c')
            {
                coalMinedCount++;
                if (coalMinedCount == coalCount)
                {
                    Console.WriteLine($"You collected all coals! ({string.Join(", ", minerPosition)})");
                    Environment.Exit(0);
                }
                field[minerPosition[0], minerPosition[1]] = '*';
            }
            else if (discoveredChar == 'e')
            {
                Console.WriteLine($"Game over! ({string.Join(", ", minerPosition)})");
                Environment.Exit(0);
            }

            return field;
        }

        public static bool IsInside(char[,] field, int row, int col) => row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
    }
}
