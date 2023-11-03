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

        //Set variables
        Console.Write("Please enter your roman numeral: ");
        userInput = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;
        romanNumerals = userInput.ToCharArray();
        decimalNumerals = new int[romanNumerals.Length];
        printedResult = 0;

        //Convert to decimal
        for (int i = 0; i < romanNumerals.Length; i++)
        {
            decimalNumerals[i] = RomanToDecimal(romanNumerals[i]);
        }

        //Check
        foreach (int item in decimalNumerals)
        {
            if (item == -1)
            {
                Console.WriteLine("Invalid roman numeral was entered, please run the code again.");
                return;
            }
        }

        //Convert to integer
        finalResult = ArrayToInteger(decimalNumerals);

        //Output
        foreach (int item in finalResult)
        {
            printedResult += item;
        }
        Console.WriteLine($"The roman numeral '{userInput}' equals {printedResult}");
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
            }
            else
            {
                if (array[i] == array[i + 1])
                {
                    if (i + 2 < array.Length && array[i + 1] == array[i + 2])
                    {
                        subArray[i] = array[i + 2] + array[i + 1] + array[i];
                        i += 2;
                    }
                    else
                    {
                        subArray[i] = array[i + 1] + array[i];
                        i++;
                    }
                }
                else
                {
                    if (array[i] > array[i + 1])
                    {
                        subArray[i] = array[i];
                        subArray[i + 1] = array[i + 1];
                    }
                }
            }
        }
        return subArray;
    }
}