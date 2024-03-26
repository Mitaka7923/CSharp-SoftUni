var numberInput = int.Parse(Console.ReadLine());

if (numberInput >= 1 && numberInput <= 20)
{
    DrawTriangle(numberInput);
}

static void DrawTriangle(int numberInput)
{
    for (int i = 1; i <= numberInput; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}