internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        ulong userInput;
        ulong tenXMultiplier;
        ulong xMultiplier;
        int total;

        //Store variables
        Console.WriteLine("Enter a max of 18 digits as one long number: ");
        userInput = Convert.ToUInt64(Console.ReadLine());
        tenXMultiplier = 10;
        xMultiplier = 1;
        total = 0;

        //Loop
        do
        {
            if ((userInput % tenXMultiplier) / xMultiplier != 0)
            {
                total = total + Convert.ToInt32((userInput % tenXMultiplier) / xMultiplier);
                tenXMultiplier = tenXMultiplier * 10;
                xMultiplier = xMultiplier * 10;
            } else {
                break;
            }
        } while (true);

        //Declare result
        Console.WriteLine($"Your digits add up to {total}");
    }
}