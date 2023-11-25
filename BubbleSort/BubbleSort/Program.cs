internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise variables
        string userInput;
        List<string> userInputs = new();
        List<string> sortedInput = new();

        //Set variables
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please enter your item, or type 'qq' to quit:");
            userInput = Console.ReadLine()?.Trim() ?? "qq";
            if (userInput == "qq")
            {
                break;
            }
            userInputs.Add(userInput.ToLower());
        }

        //Output
        Console.Clear();
        Console.WriteLine("Here is the array before sorting: ");
        userInputs.ForEach(Console.Write);
        Console.WriteLine();
        Console.WriteLine();

        //Sort
        if (userInputs.All(item => int.TryParse(item, out _)))
        {
            sortedInput = SortedNumbers(userInputs.Select(int.Parse).ToArray()).ToList();
        }
        else
        {
            sortedInput = SortedStrings(userInputs.ToArray()).ToList();
        }

        //Output
        Console.WriteLine("Here is the array after sorting: ");
        sortedInput.ForEach(Console.Write);
        Console.WriteLine();
    }

    private static string[] SortedNumbers(int[] numbers)
    {
        //Declare variables
        bool hasArranged;
        string[] orderedNumbers = new string[numbers.Length];

        //Set variable
        hasArranged = true;

        //Loop
        while (hasArranged)
        {
            hasArranged = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
                    hasArranged = true;
                }
            }
        }

        //Convert
        for (int i = 0; i < numbers.Length; i++)
        {
            orderedNumbers[i] = numbers[i].ToString();
        }

        //Output
        return orderedNumbers;
    }

    private static string[] SortedStrings(string[] strings)
    {
        //Declare variables
        bool hasArranged;

        //Set variable
        hasArranged = true;

        //Loop
        while (hasArranged)
        {
            hasArranged = false;
            for (int i = 0; i < strings.Length - 1; i++)
            {
                if (strings[i].CompareTo(strings[i + 1]) > 0)
                {
                    (strings[i], strings[i + 1]) = (strings[i + 1], strings[i]);
                    hasArranged = true;
                }
            }
        }

        //Output
        return strings;
    }
}