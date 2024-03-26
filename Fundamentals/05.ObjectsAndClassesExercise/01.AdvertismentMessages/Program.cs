namespace _01._AdvertismentMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var messageCount = int.Parse(Console.ReadLine());
            var messages = GenerateMessages(messageCount);

            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }

        static string[] GenerateMessages(int count)
        {
            var phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            var events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var messages = new string[count];
            var rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                messages[i] = $"{phrases[rnd.Next(0, phrases.Length)]} {events[rnd.Next(0, events.Length)]} {authors[rnd.Next(0, authors.Length)]} - {cities[rnd.Next(0, cities.Length)]}";
            }

            return messages;
        }
    }
}