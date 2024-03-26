var username = Console.ReadLine();
var charUsername = username.ToCharArray();
Array.Reverse(charUsername);
var password = new string(charUsername);
var maxAttempts = 4;

for (int i = 1; i <= maxAttempts; i++)
{
    var inputPassword = Console.ReadLine();

    if (inputPassword == password)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else if (i == maxAttempts)
    {
        Console.WriteLine($"User {username} blocked!");
    }
    else
    {
        Console.WriteLine("Incorrect password. Try again.");
    }
}