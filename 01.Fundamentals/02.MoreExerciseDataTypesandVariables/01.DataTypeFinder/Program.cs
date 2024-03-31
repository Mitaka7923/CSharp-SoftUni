namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<string>();
            var input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input.Equals("END"))
                    break;
                else
                    inputs.Add(input);
            }

            foreach (var value in inputs)
            {
                Console.WriteLine($"{value} is {GetType(value)} type");
            }
        }

        static string GetType(string str)
        {
            if (int.TryParse(str, out int integer))
                return "integer";
            else if (double.TryParse(str, out double floating))
                return "floating point";
            else if (bool.TryParse(str, out bool boolean))
                return "boolean";
            else if (char.TryParse(str, out char character))
                return "character";
            else
                return "string";
        }
    }
}
