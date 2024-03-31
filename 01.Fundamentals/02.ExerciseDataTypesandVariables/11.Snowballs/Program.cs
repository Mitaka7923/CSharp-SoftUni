using System;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var snowballCount = int.Parse(Console.ReadLine());
            if (snowballCount > 100 || snowballCount < 0)
            {
                throw new IndexOutOfRangeException("Invalid Snowball count. Should be between 0-100");
            }

            var bestValue = 0.0;
            var bestSnow = 0;
            var bestTime = 0;
            var bestQuality = 0;

            for (int i = 0; i < snowballCount; i++)
            {
                var snow = int.Parse(Console.ReadLine());
                var time = int.Parse(Console.ReadLine());
                var quality = int.Parse(Console.ReadLine());

                var value = Math.Pow((double)snow / time, quality);

                if (value > bestValue)
                {
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                    bestValue = value;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue:F0} ({bestQuality})");
        }
    }
}