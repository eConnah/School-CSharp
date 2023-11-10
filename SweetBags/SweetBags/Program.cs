internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int sweetBags;
        int sweets;

        //Set variables
        Console.Write("How many sweet bags do you have: ");
        sweetBags = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("How many sweets do you have: ");
        sweets = int.Parse(Console.ReadLine() ?? string.Empty);

        //Convert
        if ((sweets - (sweetBags - 1)) % 2 != 0)
        {
            Console.WriteLine("You can have an odd number of sweets in each bag.");
        }
        else
        {
            Console.WriteLine("You can't have an odd number of sweets in each bag.");
        }
    }
}