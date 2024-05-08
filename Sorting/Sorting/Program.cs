internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<string> starter = new() { "Ava", "Ethan", "Olivia", "Noah", "Emma", "Liam", "Aria", "Benjamin", "Sophia", "Jacob", "Mia", "William", "Isabella"};
        Console.WriteLine(BinarySearch(starter, "Mia"));
    }

    private static List<string> BubbleSort(List<string> items)
    {
        bool changed;
        do
        {
            changed = false;
            for (int i = 0; i < items.Count - 1; i++)
            {
                if (string.Compare(items[i], items[i + 1]) > 0)
                {
                    (items[i], items[i + 1]) = (items[i + 1], items[i]);
                    changed = true;
                }
            }
        } while (changed);
        return items;
    }

    private static int LinearSearch(List<string> items, string item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == item)
            {
                return i;
            }
        }
        return -1;
    }

    private static int BinarySearch(List<string> items, string item)
    {
        int midPoint = (items.Count / 2) - 1;
        int difference = (midPoint + 1) / 2;
        int i = midPoint;
        while (true)
        {
            if (string.Compare(items[i], item) == 0)
            {
                return i;
            }
            else if (string.Compare(items[i], item) < 0)
            {
                i = midPoint + difference;
                difference /= 2;
            }
            else
            {
                i = midPoint - difference;
                difference /= 2;
            }
        }
    }
}