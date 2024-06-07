internal class Program
{
    private static void Main(string[] args)
    {
        int happinessNumber = 0;
        string userInput;
        Console.Write("Please enter your string: ");
        userInput = Console.ReadLine();
        for (int i = 1; i < userInput.Length; i++)
        {
            if (userInput[i] == ':')
            {
                if (userInput[i - 1] == ')')
                {
                    happinessNumber--;
                }
                else if (userInput[i - 1] == '(')
                {
                    happinessNumber++;
                }
            }
            else if (userInput[i] == ')')
            {
                if (userInput[i - 1] == ':')
                {
                    happinessNumber++;
                }
            }
            else
            {
                if (userInput[i - 1] == ':')
                {
                    happinessNumber--;
                }
            }
        }
        Console.WriteLine($"Your happiness number is: {happinessNumber}");
    }
}