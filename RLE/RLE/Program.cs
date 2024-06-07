internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string userInput = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        int repeat = 0;
        char lastLetter = userInput[0];
        List<(char, int)> compressed = new();
        foreach (char item in userInput.ToLower())
        {
            if (item == lastLetter)
            {
                repeat++;
            }
            else
            {
                compressed.Add((lastLetter, repeat));
                repeat = 1;
            }
            lastLetter = item;
        }
        compressed.Add((lastLetter, repeat));
        foreach ((char itemC, int itemI) in compressed)
        {
            Console.Write($"{itemC} {itemI} ");
        }
        Console.WriteLine();
    }
}