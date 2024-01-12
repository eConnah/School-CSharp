internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initialise variables
        string inputOne;
        string inputTwo;
        List<char> container = new();
        bool isPossible = true;


        //Set variables
        inputOne = AcceptInput("Please enter your first word: ");
        inputTwo = AcceptInput("Please enter your second word: ");
        Console.Clear();

        //Check
        foreach (char item in inputTwo)
        {
            container.Add(item);
        }
        foreach (char item in inputOne)
        {
            if (!container.Contains(item))
            {
                isPossible = false;
                break;
            }
            else
            {
                container.Remove(item);
            }
        }

        //Output
        if (isPossible)
        {
            Console.WriteLine("The first word can be made from the second word.");
        }
        else
        {
            Console.WriteLine("The first word cannot be made from the second word.");
        }
    }

    private static string AcceptInput(string prompt)
    {
        //Declare variables
        string userInput;

        //Accept input
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            userInput = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
            if (!string.IsNullOrEmpty(userInput))
            {
                return userInput;
            }
            Console.Clear();
            Console.WriteLine("Please enter a proper string.");
        }
    }
}