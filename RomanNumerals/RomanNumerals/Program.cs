internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string userInput;
        char[] romanNumerals;
        int[] decimalNumerals;
        int[] finalResult;
        int printedResult;

        //Loop with checks
        do
        {
            //Set variables
            Console.Write("Please enter your roman numeral: ");
            userInput = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;
            romanNumerals = userInput.ToCharArray();
            decimalNumerals = new int[romanNumerals.Length];

            //Convert to decimal
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                decimalNumerals[i] = RomanToDecimal(romanNumerals[i]);
            }
        } while (ValidCheck(decimalNumerals) || RepeatCheck(decimalNumerals) || OrderCheck(decimalNumerals));

        //Convert to integer
        finalResult = ArrayToInteger(decimalNumerals);

        //Output
        printedResult = finalResult.Sum();
        Console.WriteLine($"The roman numeral '{userInput}' equals {printedResult}");
    }

    private static (int, int) RepeatRule(int i)
    {
        //Declare and intilise variables
        int[,] rules =
        {
            { 1, 3 },
            { 5, 1 },
            { 10, 3 }
        };

        //Return
        return (rules[i, 0], rules[i, 1]);
    }

    private static int RomanToDecimal(char romanNumeral)
    {
        return romanNumeral switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            _ => -1,
        };
    }

    private static int[] ArrayToInteger(int[] array)
    {
        //Declare and intilise variables
        int[] subArray = new int[array.Length];

        //Convert
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                subArray[i] = array[i + 1] - array[i];
                i++;
            }
            else
            {
                subArray[i] = array[i];
            }
        }
        subArray[^1] = array[^1];
        return subArray;
    }

    private static bool ValidCheck(int[] array)
    {
        foreach (int item in array)
        {
            if (item == -1)
            {
                Console.WriteLine("Roman numerals can only contain I, V, X.");
                return true;
            }
        }
        return false;
    }

    private static bool RepeatCheck(int[] array)
    {
        //Declare variables
        int number;
        int count;

        //Loop
        for (int i = 0; i < 3; i++)
        {
            (number, count) = RepeatRule(i);
            if (array.Count(x => x == number) > count)
            {
                Console.WriteLine("Certain roman numerals can only be repeated a set amount.");
                return true;
            }
        }
        return false;
    }

    private static bool OrderCheck(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] && i > 0)
            {
                if (array[i - 1] < array[i + 1])
                {
                    Console.WriteLine("Roman numerals must be in the correct order.");
                    return true;
                }
            }

        }
        return false;
    }
}