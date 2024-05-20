using System;

var sizeOfMatrix = int.Parse(Console.ReadLine());
var matrix = new int[sizeOfMatrix, sizeOfMatrix];
var sums = new int[2];

for (int i = 0; i < sizeOfMatrix; i++)
{
	var rowData = Console.ReadLine().Split().Select(int.Parse).ToList();
	for (int j = 0; j < rowData.Count; j++)
	{
		matrix[i,j] = rowData[j];
	}
}

for (int i = 0; i < sizeOfMatrix; i++)
{
	sums[0] += matrix[i, i];
	sums[1] += matrix[i, sizeOfMatrix - 1 - i];
}

var difference = Math.Abs(sums[0] - sums[1]);
Console.WriteLine(difference);