internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        List<int> listOne = new() { 2, 5, 15, 36, 47, 56, 59, 78, 156, 244, 268 };
        List<int> listTwo = new() { 18, 39, 42, 43, 66, 69, 100 };
        List<int> listThree = new();
        foreach (int item in listOne)
        {
            listThree.Add(item);
            Console.Write($"{item} ");
        }
        Console.WriteLine("- ListOne");
        foreach (int item in listTwo)
        {
            listThree.Add(item);
            Console.Write($"{item} ");
        }
        Console.WriteLine("- ListTwo");
        foreach (int item in listThree)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("- ListThree");
    }
}