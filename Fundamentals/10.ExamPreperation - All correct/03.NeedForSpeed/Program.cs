
namespace _03.NeedForSpeed
{
    internal class Car
    {
        public string Name { get; set; }
        public double Mileage { get; set; }
        public double Fuel { get; set; }

        public Car(string name, double mileage, double fuel)
        {
            this.Name = name;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public void DisplayInfo() => Console.WriteLine($"{this.Name} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.");
    }

    internal class Program
    {
        private static Car car;
        private static List<Car> cars = new();

        static void Main(string[] args)
        {
            var carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                var carData = Console.ReadLine().Split('|');
                cars.Add(new Car(carData[0], double.Parse(carData[1]), double.Parse(carData[2])));
            }

            var command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                var commandData = command.Split(" : ");
                
                car = cars.Find(x => x.Name == commandData[1]);
                switch (commandData[0])
                {
                    case "Drive": Drive(commandData); break;
                    case "Refuel": Refuel(commandData); break;
                    case "Revert": Revert(commandData); break;
                    default: break;
                }
            }

            cars.ForEach(x => x.DisplayInfo());
        }

        private static void Refuel(string[] commandData)
        {
            var fuel = double.Parse(commandData[2]);
            var requiredFuel = 75 - car.Fuel;
            if (fuel <= requiredFuel)
            {
                car.Fuel += fuel;
                Console.WriteLine($"{car.Name} refueled with {fuel} liters");
            }
            else
            {
                car.Fuel += requiredFuel;
                Console.WriteLine($"{car.Name} refueled with {requiredFuel} liters");
            }
        }

        private static void Revert(string[] commandData)
        {
            var distance = double.Parse(commandData[2]);
            car.Mileage -= distance;
            if (car.Mileage < 10000)
                car.Mileage = 10000;
            else
                Console.WriteLine($"{car.Name} mileage decreased by {distance} kilometers");
        }

        private static void Drive(string[] commandData)
        {
            var fuel = double.Parse(commandData[3]);
            var distance = double.Parse(commandData[2]);

            if (car.Fuel >= fuel)
            {
                car.Mileage += distance;
                car.Fuel -= fuel;
                Console.WriteLine($"{car.Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (car.Mileage >= 100000)
                {
                    cars.Remove(car);
                    Console.WriteLine($"Time to sell the {car.Name}!");
                }
            }
            else
                Console.WriteLine("Not enough fuel to make that ride");
        }
    }
}
