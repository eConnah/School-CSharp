internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and Initialise Variables
        Dictionary<char, int> letterCount = new();
        List<char> commonLetters = new();
        int highestCount = 0;

        //Set variables
        foreach (char item in GetInput("Enter a word: "))
        {
            if (!letterCount.ContainsKey(item))
            {
                letterCount.Add(item, 1);
            }
            else
            {
                letterCount[item]++;
            }
        }

        //Count
        foreach (char item in letterCount.Keys)
        {
            if (letterCount[item] > highestCount)
            {
                commonLetters.Clear();
                highestCount = letterCount[item];
                commonLetters.Add(item);
            }
            else if (letterCount[item] == highestCount)
            {
                commonLetters.Add(item);
            }
        }

        //Output
        commonLetters.Sort();
        foreach (char item in commonLetters)
        {
            Console.Write($"{item} ");
        }
        if (commonLetters.Count == 1)
        {
            Console.WriteLine("- Is the most common letter.");
        }
        else
        {
            Console.WriteLine("- Are the most common letters.");
        }
    }

    private static string GetInput(string prompt)
    {
        string input;
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input cannot be empty, try again.");
            }
        }
    }
}