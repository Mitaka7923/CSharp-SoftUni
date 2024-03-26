namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reversed = input.Reverse().ToArray();

            Console.WriteLine(new string(reversed));
        }
    }
}
