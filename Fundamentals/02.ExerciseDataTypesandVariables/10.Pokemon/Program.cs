namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var targetDistance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());
            var percentage = pokePower * 0.5D;
            
            var pokedTargets = 0;

            while (pokePower >= targetDistance)
            {
                pokedTargets++;
                pokePower -= targetDistance;
                if (pokePower == percentage && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
