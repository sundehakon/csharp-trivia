Console.Write("Select difficulty (Easy, Medium, Hard): ");
string userDifficulty = Console.ReadLine();

if (string.Equals(userDifficulty, "easy", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("What is the capital of Norway?: ");
    string userInput = Console.ReadLine();

    if (string.Equals(userInput, "oslo", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }

    Console.Write("Where am i from?: ");
    string userInput = Console.ReadLine();

    if (string.Equals(userInput, "norway", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }

} else if (string.Equals(userDifficulty, "medium", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("What is the capital of Sweden?: ");
    string userInput = Console.ReadLine();

    if (string.Equals(userInput, "stockholm", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }
} else if (string.Equals(userDifficulty, "hard", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("What is the capital of Brazil?: ");
    string userInput = Console.ReadLine();

    if (string.Equals(userInput, "brasilia", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }
} else 
{
    Console.WriteLine("Please type either easy, medium or hard!");
}