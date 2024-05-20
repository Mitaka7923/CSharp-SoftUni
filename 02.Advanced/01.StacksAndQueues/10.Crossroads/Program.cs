var greenLightDuration = int.Parse(Console.ReadLine());
var freeWindow = int.Parse(Console.ReadLine());

var currGreenLight = greenLightDuration;
Queue<string> cars = new();
var carsPassed = 0;

var command = "";
while (command != "END")
{
    command = Console.ReadLine();
    if (command == "green")
    {
        currGreenLight = greenLightDuration;

        for (int i = 0; i <= cars.Count; i++)
        {
            if (currGreenLight > 0)
            {
                var currCar = cars.Dequeue();

                if (currCar.Length <= currGreenLight + freeWindow)
                {
                    currGreenLight -= currCar.Length;
                    carsPassed++;
                }
                else
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currCar} was hit at {currCar[currGreenLight + freeWindow]}.");
                }
            }
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassed} total cars passed the crossroads.");