using System;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var explodedText = new StringBuilder();

            var strength = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    strength += text[i + 1] - '0';
                    explodedText.Append(text[i]);
                }
                else if (strength > 0)
                    strength--;
                else
                    explodedText.Append(text[i]);
            }

            Console.WriteLine(explodedText);
        }
    }
}