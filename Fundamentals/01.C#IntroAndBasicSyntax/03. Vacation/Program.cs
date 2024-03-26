var groupCount = int.Parse(Console.ReadLine());
var groupType = Console.ReadLine();
var dayOfWeek = Console.ReadLine();

var price = 0M;

var studentsDictionaryPrices = new Dictionary<string, decimal>() 
{
    { "Friday", 8.45M },
    { "Saturday", 9.8M },
    { "Sunday", 10.46M },
};
var businessDictionaryPrices = new Dictionary<string, decimal>()
{
    { "Friday", 10.9M },
    { "Saturday", 15.6M },
    { "Sunday", 16M },
};
var regularDictionaryPrices= new Dictionary<string, decimal>()
{
    { "Friday", 15M },
    { "Saturday", 20M },
    { "Sunday", 22.5M },
};

switch (groupType)
{
    case "Students":
        price = groupCount * studentsDictionaryPrices[dayOfWeek];
        if (groupCount >= 30)
        {
            price *= 0.85M;
        }
        break;
    case "Business":
        price = groupCount * businessDictionaryPrices[dayOfWeek];
        if (groupCount >= 100)
        {
            price -= 10 * businessDictionaryPrices[dayOfWeek];
        }
        break;
    case "Regular":
        price = groupCount * regularDictionaryPrices[dayOfWeek];
        if (groupCount >= 10 && groupCount <= 20)
        {
            price *= 0.95M;
        }
        break;
}

Console.WriteLine($"Total price: {price:F2}");