internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(SumEven(10));
    }

    public static int SumEven(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n % 2 == 0)
        {
            return n + SumEven(n - 2);
        }
        else
        {
            return n + SumEven(n - 1);
        }
    }
}