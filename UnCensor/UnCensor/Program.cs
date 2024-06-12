internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Enter your text: ");
        string text = Console.ReadLine();
        Console.Write("Enter your censored characters: ");
        string characters = Console.ReadLine();
        Console.WriteLine(UnCensor(text, characters));
    }

    private static string UnCensor(string text, string characters)
    {
        string result = string.Empty;
        int index = 0;
        foreach (char item in text)
        {
            if (item != '*')
            {
                result += item;   
            }
            else
            {
                result += characters[index];
                index++;
            }
        }
        return result;
    }
}