namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            
            while (true) 
            {
                var input = Console.ReadLine();
                if (input == "end")
                    break;

                var inputData = input.Split(" : ");
                if (courses.ContainsKey(inputData[0]))
                    courses[inputData[0]].Add(inputData[1]);
                else
                    courses.Add(inputData[0], new List<string> { inputData[1] });
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
