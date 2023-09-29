
internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int num;
        int totalNum;

        //Set variables
        Console.WriteLine("Enter a number: ");
        totalNum = num = Convert.ToInt32(Console.ReadLine());
        
        //Loop
        for (int i = num - 1; i > 1; i--)
        {
            totalNum *= i;
        }
        
        //Output
        Console.WriteLine($"{num} factorial is {totalNum}.");
    }
}