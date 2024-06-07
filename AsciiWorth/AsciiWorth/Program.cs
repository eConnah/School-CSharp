internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter your word: ");
        string word = Console.ReadLine();
        int worth;
        List<string> words = new();
        words = word.Split(' ').ToList();
        List<int> worths = new();
        foreach (string itemW in words)
        {
            worth = 0;
            foreach (char itemC in itemW)
            {
                worth += Convert.ToInt32(itemC);
            }
            worths.Add(worth);
        }

        foreach (int item in worths)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine($"The total value is {worths.Sum()}");
    }
}