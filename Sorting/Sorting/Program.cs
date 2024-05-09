internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Sophia";
        List<string> starter = new() { "Ava", "Ethan", "Olivia", "Noah", "Emma", "Liam", "Aria", "Benjamin", "Sophia", "Jacob", "Mia", "William", "Isabella"};
        List<string> sorted = BubbleSort(starter);
        Console.Clear();
        Console.WriteLine($"Binary Search found {BinarySearch(sorted, name)}.");
        Console.WriteLine($"Linear Search found {LinearSearch(sorted, name)}.");
        Console.WriteLine($"The correct value is {sorted.IndexOf(name)}.");
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
        int left = 0;
        int right = items.Count - 1;
        while (left <= right)
        {
            int index = left + (right - left) / 2;
            int comparison = items[index].CompareTo(item);
            if (comparison == 0)
            {
                return index;
            }
            else if (comparison < 0)
            {
                left = index + 1;
            }
            else
            {
                right = index - 1;
            }
        }
        return -1;
    }
}