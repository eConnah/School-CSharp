internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        bool hasTemperature;
        bool hasSoreThroat;
        bool hasCough;

        //Set variables and declare
        Console.WriteLine("Please answer the folowing questions: ");

        hasTemperature = Input("Do you have a temperature?");
        if (!hasTemperature)
        {
            Console.WriteLine("You're fine; go home.");
            return;
        }

        hasSoreThroat = Input("Do you have a sore throat?");
        if (hasSoreThroat)
        {
            Console.WriteLine("You have a throat infection.");
            return;
        }

        hasCough = Input("Do you have a cough?");
        if (hasCough)
        {
            Console.WriteLine("You have a chest infection.");
            return;
        }

        Console.WriteLine("You have a fever.");
    }
    private static bool Input(string prompt)
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
                    Console.WriteLine("Please enter a valid input. (0/1, Yes/No)");
                    break;
            }
        }
    }
}