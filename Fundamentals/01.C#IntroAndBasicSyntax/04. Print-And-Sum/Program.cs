var firstNumber = int.Parse(Console.ReadLine());
var secondNumber = int.Parse(Console.ReadLine());
var sum = 0;

var rangeOfNumbers = GetNumberRange(firstNumber, secondNumber);
rangeOfNumbers.ForEach((number) => sum += number);

Console.WriteLine(String.Join(' ', rangeOfNumbers));
Console.WriteLine($"Sum: {sum}");

static List<int> GetNumberRange(int firstNumber, int secondNumber)
{
    var numbersRange = new List<int>();
    
    for (int i = firstNumber; i <= secondNumber; i++)
    {
        numbersRange.Add(i);
    }

    return numbersRange;
}