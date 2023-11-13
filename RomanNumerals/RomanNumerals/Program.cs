using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        //Clear
        Console.Clear();

        //Declare variables
        string userInput;
        char[] romanNumerals;
        int[] decimalNumerals;
        int finalResult;

        //Loop with checks
        do
        {
        LoopStart:
            //Set variables
            Console.Write("Please enter your roman numeral: ");
            userInput = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;
            romanNumerals = userInput.ToCharArray();
            decimalNumerals = new int[romanNumerals.Length];

            //Quick check
            if (string.IsNullOrEmpty(userInput))
            {
                Console.Clear();
                Console.WriteLine("Null inputs not accepted.");
                goto LoopStart;
            }

            //Convert to decimal
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                decimalNumerals[i] = RomanToDecimal(romanNumerals[i]);
            }
        } while (ValidCheck(decimalNumerals) || RepeatCheck(decimalNumerals) || OrderCheck(decimalNumerals));

        //Convert to integer
        finalResult = ArrayToInteger(decimalNumerals);

        //Output
        Console.WriteLine($"The roman numeral '{userInput}' equals {finalResult}.");
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

    private static int ArrayToInteger(int[] array)
    {
        //Declare and intilise variables
        int total = 0;

        //Convert
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                total += array[i + 1] - array[i];
                i++;
            }
            else
            {
                total += array[i];
            }
        }
        total += array[^1];
        return total;
    }

    private static bool ValidCheck(int[] array)
    {
        foreach (int item in array)
        {
            if (item == -1)
            {
                Console.Clear();
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
                Console.Clear();
                Console.WriteLine("Certain roman numerals can only be repeated a set amount of times.");
                return true;
            }
        }
        return false;
    }

    private static bool OrderCheck(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (i + 2 < array.Length && array[i] < array[i + 1] && array[i] <= array[i + 2])
            {
                Console.Clear();
                Console.WriteLine("Roman numerals must be in the correct order.");
                return true;
            }
            if (i > 0 && array[i] < array[i + 1] && array[i - 1] <= array[i])
            {

                Console.Clear();
                Console.WriteLine("Roman numerals must be in the correct order.");
                return true;
            }
        }
        return false;
    }
}