namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wagonCount = int.Parse(Console.ReadLine());
            var passengersPerWagon = new int[wagonCount];
            var totalPassengers = 0;

            for (int i = 0; i < wagonCount; i++)
            {
                passengersPerWagon[i] = int.Parse(Console.ReadLine());
                totalPassengers += passengersPerWagon[i];
            }

            Console.WriteLine(String.Join(' ', passengersPerWagon));
            Console.WriteLine(totalPassengers);
        }
    }
}
