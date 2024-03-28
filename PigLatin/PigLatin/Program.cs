internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        char firstChar;
        string word;
        List<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        //Set variables
        Console.Write("Please enter your word: ");
        word = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        firstChar = word[0];
        if (vowels.Contains(firstChar))
        {
            word += "-yay";
        }
        else
        {
            word = word[1..];
            word = word + '-' + firstChar + "ay";
        }

        //Output
        Console.WriteLine($"The pig latin of your word is {word}.");
    }
}