using System.Text;

var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
var str = Console.ReadLine();
var sb = new StringBuilder();

var matrix = new char[matrixSize[0], matrixSize[1]];

for (int i = 0, l = 0; i < matrixSize[0]; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 0; j < matrixSize[1]; j++)
        {
            if (l == str.Length)
            {
                l = 0;
            }
            matrix[i, j] = str[l++];
        }
    }
    else
    {
        for (int j = matrixSize[1]; j > 0; j--)
        {
            if (l == str.Length)
            {
                l = 0;
            }
            matrix[i, j - 1] = str[l++];
        }
    }
}

for (int i = 0; i < matrixSize[0]; i++)
{
    for (int j = 0; j < matrixSize[1]; j++)
    {
        sb.Append($"{matrix[i, j]}");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);