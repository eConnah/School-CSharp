internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise variables
        int bracketCount = 0;
        string userInput;
        bool isInvalid = false;

        //Get user input
        Console.Clear();
        Console.Write("Please enter your string with brackets: ");
        userInput = Console.ReadLine()?.Trim() ?? string.Empty;
        Console.Clear();

        //Check for brackets
        foreach (char item in userInput)
        {
            if (item == '(')
            {
                bracketCount++;
            }
            else if (item == ')')
            {
                bracketCount--;
            }
            if (bracketCount < 0)
            {
                isInvalid = true;
                break;
            }
        }

        //Output
        if (isInvalid)
        {
            Console.WriteLine("This string with brackets is invalid.");
        }
        else
        {
            Console.WriteLine("This string with brackets is valid.");
        }
    }
}