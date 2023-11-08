internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables and intilize
        int[] intArray;
        string userInput;
        int arraySize;

        //Set variables
        Console.Write("How many numbers would you like to enter: ");
        arraySize = Convert.ToInt32(Console.ReadLine());
        intArray = new int[arraySize];
        Console.WriteLine("Please enter your numbers.");
        for (int i = 0; i < arraySize; i++)
        {
            userInput = Console.ReadLine() ?? string.Empty;
            if (userInput == string.Empty)
            {
                Console.WriteLine("Empty inputs not accepted. Try again.");
                i--;
            }
            else
            {
                intArray[i] = Convert.ToInt32(userInput);
            }
        }

        //Output
        Console.WriteLine(intArray.Average());
    }
}