namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Stack<int>();
            var clothesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var maxRackCapacity = int.Parse(Console.ReadLine());
            var rackSum = 0;
            var racksUsed = 1;

            foreach (var item in clothesInput)
            {
                clothes.Push(item);
            }

            while (clothes.Count > 0)
            {
                var currItem = clothes.Pop();
                if (rackSum + currItem > maxRackCapacity)
                {
                    rackSum = 0;
                    racksUsed++;
                }

                rackSum += currItem;
            }

            Console.WriteLine(racksUsed);
        }
    }
}