namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ');
            var modifiedArray = new string[array.Length];
            var positions = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(' ', modifiedArray));
        }
    }
}
