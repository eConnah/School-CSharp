internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initialise variables
        string userInput;
        List<char> container = new();
        List<char> missingLetters = new();
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        bool isMissing = false;

        //Set variables
        userInput = AcceptInput("Please enter your sentance: ");
        Console.Clear();

        //Check
        foreach (char item in userInput)
        {
            if (!container.Contains(item))
            {
                container.Add(item);
            }   
        }
        for (int i = 0; i < alphabet.Length; i++)
        {
            if (!container.Contains(alphabet[i]))
            {
                missingLetters.Add(alphabet[i]);
                isMissing = true;
            }
        }

        //Output
        if (isMissing)
        {
            Console.WriteLine("This sentance is not a pangram.");
            Console.WriteLine($"The missing letters are: {string.Join(", ", missingLetters)}.");
        }
        else
        {
            Console.WriteLine("This sentance is a pangram.");
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