internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string userInput;
        int[] intArray;

        //Set variables
        Console.Write("Please enter your number: ");
        userInput = Console.ReadLine() ?? string.Empty;
        intArray = new int[userInput.Length];

        //Convert
        for (int i = 0; i < userInput.Length; i++)
        {
            intArray[i] = int.Parse(userInput[i].ToString());
        }

        //Check
        for (int i = 0; i < intArray.Length; i++)
        {
            if (i + 1 < intArray.Length)
            {
                if (intArray[i] - intArray[i + 1] > 1 || intArray[i] - intArray[i + 1] < -1)
                {
                    Console.WriteLine("Your number is not jumbled.");
                    return;
                }
            }
        }
        Console.WriteLine("Your number is jumbled.");
    }
}