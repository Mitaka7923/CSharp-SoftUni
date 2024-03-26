namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commandCount = int.Parse(Console.ReadLine());
            var customers = new Dictionary<string, string>();

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split(' ');
                
                if (command[0].ToLower().Equals("register"))
                {
                    if (customers.ContainsKey(command[1]))
                        Console.WriteLine($"ERROR: already registered with plate number {customers[command[1]]}");
                    else
                    {
                        customers.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0].ToLower().Equals("unregister"))
                {
                    if (!customers.ContainsKey(command[1]))
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    else
                    {
                        customers.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                }
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Key} => {customer.Value}");
            }
        }
    }
}
