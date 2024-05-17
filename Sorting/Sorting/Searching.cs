namespace Searching;
{
public class Linear
{
    public static int Search(List<string> items, string item)
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
}
public class Binary
{
    public static int Search(List<string> items, string item)
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
}