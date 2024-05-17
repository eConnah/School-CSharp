namespace Sorting
{
    public class Bubble
    {
        public static List<string> Sort(List<string> items)
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
    }
}