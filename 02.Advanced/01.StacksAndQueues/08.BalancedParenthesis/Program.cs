using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().ToCharArray();
            Stack<char> left = new();
            Dictionary<char, char> parentheses = new() { { '(', ')' }, { '[', ']' }, { '{', '}' } };

            if (sequence.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                switch (sequence[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        left.Push(sequence[i]);
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if (parentheses[left.Pop()] != sequence[i])
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine("YES");
        }
    }
}