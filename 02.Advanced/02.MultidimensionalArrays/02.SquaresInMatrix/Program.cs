var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
var matrix = new char?[matrixSize[0], matrixSize[1]];
var squareCount = 0;

for (int i = 0; i < matrixSize[0]; i++)
{
    var data = Console.ReadLine().Split();
    for (int j = 0; j < matrixSize[1]; j++)
    {
        matrix[i, j] = Convert.ToChar(data[j]);
    }
}

for (int row = 0; row < matrixSize[0]; row++)
{
    for (int col = 0; col < matrixSize[1]; col++)
    {
        if (row != matrixSize[0] - 1 && col != matrixSize[1] - 1)
        {
            if (matrix[row, col] == matrix[row, col + 1] && 
                matrix[row, col] == matrix[row + 1, col] && 
                matrix[row, col] == matrix[row + 1, col + 1])
            {
                squareCount++;
            }
        }
        
    }
}

Console.WriteLine(squareCount);