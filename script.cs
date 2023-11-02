Console.Write("Welcome to Geography Trivia! Select difficulty (Easy, Medium, Hard): ");
string userDifficulty = Console.ReadLine();

Random random = new Random();
int randomQuestion = random.Next(1, 3);

if (string.Equals(userDifficulty, "easy", StringComparison.OrdinalIgnoreCase))
{
    if (randomQuestion == 1)
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
    } else if (randomQuestion == 2)
    {
    Console.Write("In which continent does Norway reside?: ");
    string userInput = Console.ReadLine();

    if (string.Equals(userInput, "europe", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }
    }

} else if (string.Equals(userDifficulty, "medium", StringComparison.OrdinalIgnoreCase))
{
    if (randomQuestion == 1)
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
    } else if (randomQuestion == 2)
    {
        Console.Write("In which continent does Sweden reside?");
        string userInput = Console.ReadLine();

    if (string.Equals(userInput, "europe", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }
    }

} else if (string.Equals(userDifficulty, "hard", StringComparison.OrdinalIgnoreCase))
{
    if (randomQuestion == 1)
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
    } else if (randomQuestion == 2)
    {
        Console.Write("In which continent does Brazil reside?");
        string userInput = Console.ReadLine();

    if (string.Equals(userInput, "south america", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
    } else 
    {
        Console.WriteLine("Incorrect!");
    }
    }


} else 
{
    Console.WriteLine("Please type either easy, medium or hard!");
}