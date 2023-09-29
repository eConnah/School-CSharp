internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string carChoice;
        bool proceed;

        //Set variables
        carChoice = Car("What car would you like to rent: ");
        proceed = Confirmation($"You have chosen the {carChoice}, would you like to proceed: ");

        if (proceed){
            Console.WriteLine($"Confirmed, proceeding with {carChoice}.");
        } else {
            Console.WriteLine($"Confirmed, cancelling {carChoice}.");
        }
        Console.WriteLine($"Have a nice day.");
    }
    private static string Car(string prompt)
    {
        //Declare variables
        string userInput;

        //Set variables
        Console.WriteLine(prompt);
        Console.WriteLine("0. Economy Car");
        Console.WriteLine("1. Saloon Car");
        Console.WriteLine("2. Sports Car");

        while (true)
        {
            userInput = Console.ReadLine()?.Trim()?.ToLower() ?? string.Empty;
            switch (userInput)
            {
                case "0":
                case "economy car":
                    return "Economy Car";
                case "1":
                case "saloon car":
                    return "Saloon Car";
                case "2":
                case "sports car":
                    return "Sports Car";
                default:
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }
        }
    }
    private static bool Confirmation(string prompt)
    {
        //Declare variables
        string userInput;

        //Set variables
        Console.WriteLine(prompt);
        Console.WriteLine("0. No");
        Console.WriteLine("1. Yes");

        while (true)
        {
            userInput = Console.ReadLine()?.Trim()?.ToLower() ?? string.Empty;
            switch (userInput)
            {
                case "0":
                case "no":
                    return false;
                case "1":
                case "yes":
                    return true;
                default:
                    Console.WriteLine("Please enter a valid input (0/1, No/Yes)");
                    break;
            }
        }
    }
}