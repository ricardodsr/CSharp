// A simple example of a class
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}


// An example of an if-else statement
if (user.Age > 18)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Sorry, you must be 18 or older to enter.");
}


// An example of a switch statement
switch (user.Name)
{
    case "John":
        Console.WriteLine("Hello, John!");
        break;
    case "Bob":
        Console.WriteLine("Hello, Bob!");
        break;
    default:
        Console.WriteLine("Hello, stranger!");
        break;
}