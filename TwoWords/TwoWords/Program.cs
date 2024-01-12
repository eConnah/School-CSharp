internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string inputOne;
        string inputTwo;
        

        //Set variables
        inputOne = AcceptInput("Please enter your first word: ");
        inputTwo = AcceptInput("Please enter your second word: ");

        inputTwo.ToList
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
            userInput = Console.ReadLine()?.Trim() ?? string.Empty;
            if (!string.IsNullOrEmpty(userInput))
            {
                return userInput;
            }
            Console.Clear();
            Console.WriteLine("Please enter a proper string.");
        }
    }
}