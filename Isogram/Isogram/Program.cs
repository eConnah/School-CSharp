internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Please enter your word: ");
        string input = Console.ReadLine().ToLower();
        if (IsIsogram(input))
        {
            Console.WriteLine($"{input} is an isogram");
        }
        else
        {
            Console.WriteLine($"{input} is not an isogram");
        }
    }

    private static bool IsIsogram(string word)
    {
        List<char> letters = new();
        foreach (char item in word)
        {
            if (!letters.Contains(item))
            {
                letters.Add(item);
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}