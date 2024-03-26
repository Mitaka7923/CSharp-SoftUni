namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commandCount = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();
            var lastCommand = string.Empty;

            for (int i = 0; i < commandCount * 2; i++)
            {
                var command = Console.ReadLine();
                if (i % 2 != 0)
                {
                    if (studentGrades.ContainsKey(lastCommand))
                        studentGrades[lastCommand].Add(double.Parse(command));
                    else
                        studentGrades[lastCommand] = new List<double>() { double.Parse(command) };
                }
                else
                    lastCommand = command;
            }

            foreach (var student in studentGrades)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
