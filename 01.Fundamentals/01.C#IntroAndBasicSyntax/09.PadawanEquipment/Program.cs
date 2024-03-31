namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            
            var studentsCount = int.Parse(Console.ReadLine());
            var lightsaberPrice = decimal.Parse(Console.ReadLine());
            var robePrice = decimal.Parse(Console.ReadLine());
            var beltPrice = decimal.Parse(Console.ReadLine());

            var freeBelts = studentsCount / 6;
            var total = lightsaberPrice * Math.Ceiling(studentsCount * 1.1M) + robePrice * studentsCount + beltPrice * (studentsCount - freeBelts);

            if (total <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - budget:f2}lv more.");
            }
        }
    }
}
