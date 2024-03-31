using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var barcodeCount = int.Parse(Console.ReadLine());
            var barcodes = new Dictionary<string, string>();

            for (int i = 0; i < barcodeCount; i++)
            {
                var group = "00";
                var input = Console.ReadLine();
                var match = Regex.Match(input, @"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+");
                
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                var digits = Regex.Matches(match.Groups["barcode"].Value, @"\d+");
                if (digits.Count > 0)
                {
                    group = string.Empty;
                    foreach (Match digit in digits)
                    {
                        group += digit.Value;
                    }
                }
                
                barcodes.Add(match.Groups["barcode"].Value, group.ToString());
                Console.WriteLine($"Product group: {barcodes[match.Groups["barcode"].Value]}");
            }

        }
    }
}
