internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables and intilize
        int[] intArray = Array.Empty<int>();
        string userInput;
        int i = 0;

        //Set variables
        while (true)
        {
            userInput = Console.ReadLine()?.Trim() ?? "rr";
            if (userInput == "qq")
            {
                break;
            }
            if (userInput == "rr")
            {
                Console.WriteLine("Empty inputs not accepted. Try again.");
                return;
            }
            intArray[i] = Convert.ToInt32(userInput);
            i++;
        }

        //Output
        Console.WriteLine(intArray.Average());
    }
}