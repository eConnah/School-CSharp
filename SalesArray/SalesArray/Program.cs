internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int quarter;
        int outletTotal;
        int[] outletOne;
	    int[] outletTwo;
        int[] outletThree;

        //Set variables
        quarter = QuarterInput();
        outletOne = new int[4] { 10, 12, 15, 10 };
        outletTwo = new int[4] { 5, 8, 3, 6 };
        outletThree = new int[4] { 10, 12, 15, 10 };

        //Output
        outletTotal = outletOne[quarter - 1];
        outletTotal += outletTwo[quarter - 1];
        outletTotal += outletThree[quarter - 1];
        Console.WriteLine($"The total for quarter {quarter} is {outletTotal}.");

    }
    private static int QuarterInput()
    {
        //Declare variables
        string userInput;
    
        //Set variables
        Console.WriteLine("Please select an option: ");
        Console.WriteLine("1. Jan-March");
        Console.WriteLine("2. April-June ");
        Console.WriteLine("3. July-Sept");
        Console.WriteLine("4. Oct-Dec");
        do
        {
            userInput = Console.ReadLine()?.Trim().ToLower() ??string.Empty;
            switch (userInput)
            {
                case "1":
                case "jan-march":
                    return 1;
                case "2":
                case "april-june":
                    return 2;
                case "3":
                case "july-sept":
                    return 3;
                case "4":
                case "oct-dec":
                    return 4;
                default:
                    Console.Write("Please use a valid input: ");
                    break;
            }
        } while (true);
    }
}