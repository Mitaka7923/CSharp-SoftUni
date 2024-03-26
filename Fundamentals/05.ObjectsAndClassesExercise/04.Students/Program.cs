using System.Threading.Channels;

namespace _04.Students
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentCount = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                students.Add(new Student(input[0], input[1], double.Parse(input[2])));
            }

            students = students.OrderBy(student => student.Grade).ToList();
            students.Reverse();
            students.ForEach((x) => Console.WriteLine(x.ToString()));
        }
    }
}
