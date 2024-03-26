namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            var encrypted = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encrypted[i] = (char)(text[i] + 3);
            }

            Console.WriteLine(new string(encrypted));
        }
    }
}
