internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int numOne;
        int numTwo;
        int tempOne;
        int tempTwo;
        Console.Write("Enter your first number: ");
        numOne = tempOne = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        numTwo = tempTwo = int.Parse(Console.ReadLine());
        while (tempOne != tempTwo)
        {
            if (tempOne > tempTwo)
            {
                tempOne -= tempTwo;   
            }
            else
            {
                tempTwo -= tempOne;
            }
        }
        Console.WriteLine($"GCF of {numOne} and {numTwo} is {tempOne}.");
    }
}