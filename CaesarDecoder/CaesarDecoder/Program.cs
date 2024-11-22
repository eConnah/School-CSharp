internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter your encypted message: ");
        string userInput = Console.ReadLine().ToUpper();
        string output = string.Empty;
        List<char> alphabet = new() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        for (int i = 1; i < 26; i++)
        {
            foreach (char letter in userInput)
            {
                
                output += alphabet[(alphabet.IndexOf(letter) + i) % 26];
            }
            Console.WriteLine(output);
            output = string.Empty;
        }
    }
}