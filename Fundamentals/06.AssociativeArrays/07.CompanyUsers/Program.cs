namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companyEmployees = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input.Trim().Equals("End"))
                    break;

                var inputData = input.Split(" -> ");
                if (companyEmployees.ContainsKey(inputData[0]))
                {
                    if (!companyEmployees[inputData[0]].Contains(inputData[1])) 
                        companyEmployees[inputData[0]].Add(inputData[1]);
                }
                else
                    companyEmployees.Add(inputData[0], new List<string> { inputData[1] });
            }

            foreach (var company in companyEmployees)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employeeId in company.Value)
                    Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}
