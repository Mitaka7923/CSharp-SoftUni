namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letterCount = int.Parse(Console.ReadLine());
            var message = GetMessage(letterCount);

            Console.WriteLine(message);
        }

        static string GetMessage(int messageLength)
        {
            var message = new char[messageLength];

            for (int i = 0; i < message.Length; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (input != 0)
                {
                    var mainDigit = Convert.ToInt32(input.ToString()[0].ToString());
                    var numberOffset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        numberOffset++;
                    }

                    var letterIndex = numberOffset + input.ToString().Length - 1;
                    message[i] = Convert.ToChar(97 + letterIndex);
                }
                else
                {
                    message[i] = ' ';
                }
            }

            return new string(message);
        }
    }
}
