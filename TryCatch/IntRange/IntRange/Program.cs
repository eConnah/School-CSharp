internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise variables
        int i = 0;
        string userInput;
        int userNumber = 0;
        List<int> userInputs = new();
        bool escape = false;

        //Set variables
        Console.WriteLine("Enter your numbers, and type qq when you are done.");
        while (!escape)
        {
            i++;
            do
            {
                Console.Write($"Please enter number {i}: ");
                userInput = Console.ReadLine()?.Trim() ?? string.Empty;
                if (userInput == "qq")
                {
                    escape = true;
                    break;
                }
            } while (!int.TryParse(userInput, out userNumber));
            userInputs.Add(userNumber);
        }
    }
}