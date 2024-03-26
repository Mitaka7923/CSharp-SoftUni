using System.ComponentModel.DataAnnotations;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lostGamesCount = int.Parse(Console.ReadLine());
            var headsetPrice = decimal.Parse(Console.ReadLine());
            var mousePrice = decimal.Parse(Console.ReadLine());
            var keyboardPrice = decimal.Parse(Console.ReadLine());
            var displayPrice = decimal.Parse(Console.ReadLine());

            var trashedHeadsetCount = 0;
            var trashedMouseCount = 0;
            var trashedKeyboardCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsetCount++;
                    if (i % 3 == 0)
                    {
                        trashedMouseCount++;
                        trashedKeyboardCount++;
                    }
                }
                else if (i % 3 == 0)
                {
                    trashedMouseCount++;
                }
            }

            var trashedDisplayCount = trashedKeyboardCount / 2;

            var rageExpences = trashedHeadsetCount * headsetPrice +
                trashedMouseCount * mousePrice +
                trashedKeyboardCount * keyboardPrice +
                trashedDisplayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");
        }
    }
}
