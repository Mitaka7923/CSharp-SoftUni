using _01._Ages;

var age = int.Parse(Console.ReadLine());
var personType = GetPersonType(age);

Console.WriteLine(personType.ToString().ToLower());

static PersonType GetPersonType(int age)
{
    var personType = new PersonType();
    switch (age)
    {
        case >= 0 and <= 2:
            personType = PersonType.Baby;
            break;
        case <= 13 and >= 3:
            personType = PersonType.Child;
            break;
        case <= 19 and >= 14:
            personType = PersonType.Teenager;
            break;
        case <= 65 and >= 20:
            personType = PersonType.Adult;
            break;
        case >= 66:
            personType = PersonType.Elder;
            break;
        default:
            throw new ArgumentException(nameof(age));
    }

    return personType;
}