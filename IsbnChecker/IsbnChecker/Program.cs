internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int[] isbn = new int[13];
        int calculatedResult = 0;

        //Set varibles
        for (int i = 0; i < isbn.Length; i++)
        {
            isbn[i] = InputConverter(i);
        }

        //Calculate result
        for (int i = 0; i < isbn.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                calculatedResult += isbn[i];
            }
            else
            {
                calculatedResult += 3 * isbn[i];
            }
        }

        //Print result
        calculatedResult %= 10;
        if (calculatedResult == 0)
        {
            calculatedResult = 10;
        }
        Console.Clear();
        if (10 - calculatedResult == isbn[^1])
        {
            Console.WriteLine("This is a valid ISBN.");
        }
        else
        {
            Console.WriteLine("This is not a valid ISBN.");
        }
    }

    private static int InputConverter(int i)
    {
        //Declare variables
        string userInput;
        int returnValue;

        //Loop until valid input
        do
        {
            Console.Clear();
            Console.Write($"Please enter digit {i + 1}: ");
            userInput = Console.ReadLine()?.Trim() ?? string.Empty;
            if (char.TryParse(userInput, out _))
            {
                if (int.TryParse(userInput, out returnValue))
                {
                    return returnValue;
                }
            }
        } while (true);
    }
}