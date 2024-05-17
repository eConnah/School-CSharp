using Sorting;
using Searching;
internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Sophia";
        List<string> starter = new() { "Ava", "Ethan", "Olivia", "Noah", "Emma", "Liam", "Aria", "Benjamin", "Sophia", "Jacob", "Mia", "William", "Isabella"};
        List<string> sorted = Bubble.Sort(starter);
        Console.Clear();
        Console.WriteLine($"Binary Search found {Binary.Search(sorted, name)}.");
        Console.WriteLine($"Linear Search found {Linear.Search(sorted, name)}.");
        Console.WriteLine($"The correct value is {sorted.IndexOf(name)}.");
    }
}