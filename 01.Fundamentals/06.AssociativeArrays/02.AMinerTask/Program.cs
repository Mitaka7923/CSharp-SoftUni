namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputCount = 0;
            var resourses = new Dictionary<string, double>();
            var lastInput = string.Empty;

            while (true) {
                var input = Console.ReadLine();
                inputCount++;

                if (input.Trim() == "stop")
                    break;
                else if (inputCount % 2 != 0)
                {
                    lastInput = input;
                    if (!resourses.ContainsKey(input))
                        resourses[input] = 0;
                }
                else
                    resourses[lastInput] += double.Parse(input);
            }

            foreach (var resourse in resourses)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
