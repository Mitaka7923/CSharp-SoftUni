var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
var matrix = new int[matrixSize[0], matrixSize[1]];

for (int i = 0; i < matrixSize[0]; i++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < matrixSize[1]; j++)
    {
        matrix[i, j] = rowData[j];
    }
}

var command = "";
while (command != "END")
{
    command = Console.ReadLine();
    var swapData = GetCommandData(command, matrixSize);
    if (swapData != null)
    {
        var temp = matrix[swapData[0], swapData[1]];
        matrix[swapData[0], swapData[1]] = matrix[swapData[2], swapData[3]];
        matrix[swapData[2], swapData[3]] = temp;
        PrintMatrix(matrix);
    }
    else if (command != "END")
    {
        Console.WriteLine("Invalid input!");
    }
}

static void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row,col]} ");
        }
        Console.WriteLine();
    }
}

static int[] GetCommandData(string command, int[] matrixSize)
{
    var tokens = command.Split();

    if (command.Contains("swap") && tokens.Length == 5 && int.TryParse(tokens[1], out int row1) &&
        int.TryParse(tokens[2], out int col1) &&
        int.TryParse(tokens[3], out int row2) &&
        int.TryParse(tokens[4], out int col2) &&
        row1 <= matrixSize[0] && row1 >= 0 &&
        row2 <= matrixSize[0] && row2 >= 0 &&
        col1 <= matrixSize[1] && col1 >= 0 &&
        col2 <= matrixSize[1] && col2 >= 0)
    {
        return new int[] { row1, col1, row2, col2 };
    }
    return null;
}