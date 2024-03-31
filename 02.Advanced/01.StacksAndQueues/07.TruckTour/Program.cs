using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var petrolPumpsOnRouteCount = int.Parse(Console.ReadLine());
            var currentPetrol = 0;
            var startIndex = 0;
            var bestData = new int[2];

            var queue = new Queue<int[]>();

            for (int i = 0; i < petrolPumpsOnRouteCount; i++)
            {
                var pumpData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pumpData);
            }

            for (int i = 0; i < petrolPumpsOnRouteCount; i++)
            {
                var pumpData = queue.Dequeue();
                currentPetrol += pumpData[0] - pumpData[1];

                if (currentPetrol < 0)
                {
                    currentPetrol = 0;
                    startIndex = i + 1;
                }
                else if (bestData[0] != pumpData[0] &&
                    bestData[1] != pumpData[1])
                {
                    bestData = pumpData;
                }
            }

            if (currentPetrol < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(startIndex);
            }
        }
    }
}
