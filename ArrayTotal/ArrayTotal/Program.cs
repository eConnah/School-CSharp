internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int[] intArray;
        int arraySum;
        double arrayAverage;
        string stringArray;

        //Set variables
        intArray = new int[6];
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine($"Please enter integer ({i + 1}/{intArray.Length}): ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                intArray[i] = userInput;
            }
            else
            {
                Console.WriteLine("Please input a valid number.");
                i--;
            }
        }
        Array.Reverse(intArray);
        stringArray = string.Join(", ", intArray);
        arrayAverage = intArray.Average();
        arraySum = intArray.Sum();
        
        //Output
        Console.Write($"Here are the numbers in reverse order: ");
        Console.WriteLine(stringArray);
        Console.Write($"Their total is {arraySum}. ");
        Console.WriteLine($"And their average is {arrayAverage}.");
    }
}