using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };
        List<char> userInputVowels = new();
        int c = 1;

        Console.Write("Please enter your string: ");

        string userInput = Console.ReadLine().Trim();
        string output = string.Empty;
        
        foreach (char item in userInput)
        {
            if (vowels.Contains(item))
            {
                userInputVowels.Add(item);
            }
        }
        foreach (char item in userInput)
        {
            if (vowels.Contains(item))
            {
                output += userInputVowels[^c];
                c++;
            }
            else
            {
                output += item;
            }
        }
        Console.WriteLine($"The swapped string is: {output}");
    }
}