var number = int.Parse(Console.ReadLine());
var divisions = new int[] { 10, 7, 6, 3, 2 };

for (int i = 0; i < divisions.Length; i++)
{
    if (number % divisions[i] == 0)
    {
        Console.WriteLine($"The number is divisible by {divisions[i]}");
        break;
    }

    if (i == divisions.Length - 1)
    {
        Console.WriteLine("Not divisible");
    }
}