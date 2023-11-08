internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and set variables
        string userInput;
        Console.Write("Please enter a number: ");
        userInput = Console.ReadLine() ?? string.Empty;
        bool unlucky = false;
        List<char> unluckyNumbers = new();

        //Loop
        for (int i = 0; i < userInput.Length; i++)
        {
            for (int j = 0; j < userInput.Length; j++)
            {
                if (userInput[i] == userInput[j] && i != j)
                {
                    if (!unluckyNumbers.Contains(userInput[i]))
                    {
                        unluckyNumbers.Add(userInput[i]);
                    }
                    unlucky = true;
                }
            }
        }

        //Output
        unluckyNumbers.Sort();
        if (unlucky)
        {
            Console.Write("This number is unlucky. The repeated number(s) are: ");
            foreach (char item in unluckyNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Your number is lucky!");
        }
    }
}