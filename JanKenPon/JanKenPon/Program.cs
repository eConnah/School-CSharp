internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    private static string RockPaperScissors(int hand)
    {
        return hand switch
        {
            1 => "Rock",
            2 => "Paper",
            3 => "Scissors",
            _ => string.Empty,
        };
    }
}