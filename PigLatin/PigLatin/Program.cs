internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        char temp;
        string word;

        //Set variables
        Console.Write("Please enter your word: ");
        word = Console.ReadLine()?.Trim() ?? string.Empty;
        temp = word[0];
        word = word[1..];
        word = word + '-' + temp + "ay";

        //Output
        Console.WriteLine($"The pig latin of your word is {word}.");
    }
}