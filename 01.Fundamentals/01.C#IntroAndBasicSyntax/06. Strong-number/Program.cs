using System;
using System.Reflection.Metadata.Ecma335;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine();
            var numbersChar = numberString.ToCharArray();
            var numbers = new int[numberString.Length];

            for (int i = 0; i < numbersChar.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbersChar[i].ToString());
            }

            if (DetermineStrong(numbers, int.Parse(numberString)))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static bool DetermineStrong(int[] numbers, int number)
        {
            var sum = (long)0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += CalculateFactorial(numbers[i]);
            }

            if (sum == number) return true;

            return false;
        }

        static long CalculateFactorial(int number)
        {
            var fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            return fact;
        }
}
}