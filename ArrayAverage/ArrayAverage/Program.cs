internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int arrayLength;
        int[] inputArray = new int[5];

        //Set variables
        do
        {
            arrayLength = InputValidator("Please enter the length of the array you would like (must be above 0): ");
        } while (arrayLength < 1);
        for (int i = 0; i < arrayLength; i++)
        {
            inputArray[i] = InputValidator($"Enter number {i + 1}: ");
        }

        //Print
        Console.Clear();
        Console.WriteLine($"The sum of the array is: {inputArray.Sum()}.");
        Console.WriteLine($"The average of the array is: {inputArray.Average()}.");
    }

    private static int InputValidator(string prompt)
    {
        //Set variables
        Console.Clear();
        do
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("An invalid input has been entered.");
            }
        } while (true);
    }
}