internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int fishSize;
        string fishState;

        //Set variables
        fishSize = 1;
        fishState = "Fish";
        Console.WriteLine($"{fishState} is of size {fishSize}");

        //Loop
        do
        {
            (fishState, fishSize) = Feed(fishSize);
        } while (!String.Equals(fishState, "FISH"));

        Console.WriteLine($"It is now a big {fishState}.");
    }

    private static (string, int) Feed(int fishSize)
    {
        fishSize++;
        Console.WriteLine("Fish fed.");
        if (fishSize >= 5)
        {
            return ("FISH", fishSize);
        }
        else
        {
            return ("Fish", fishSize);
        }
    }
}