internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter your word: ");
        string word = Console.ReadLine();
        int worth = 0;
        foreach (char item in word)
        {
            worth += Convert.ToInt32(item);
        }
        Console.WriteLine($"The value of your word is {worth}.");
    }
}