namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var occurances = new Dictionary<char, int>();
            var word = Console.ReadLine();

            foreach (var ch in word)
            {
                if (!occurances.ContainsKey(ch))
                {
                    occurances[ch] = 0;
                }
                occurances[ch]++;
            }

            foreach (var (ch,times) in occurances.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{ch}: {times} time/s");
            }
        }
    }
}
