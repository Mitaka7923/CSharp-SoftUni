namespace ExerciseDataTypesandVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tankMaxCapacity = 255.0;
            var tankCapacity = 0.0;
            var pourCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pourCount; i++)
            {
                var waterToPour = double.Parse(Console.ReadLine());
                if ((tankCapacity + waterToPour) <= tankMaxCapacity)
                {
                    tankCapacity += waterToPour;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(tankCapacity);
        }
    }
}
