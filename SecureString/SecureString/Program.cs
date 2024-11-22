internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        int charValue;
        bool isAlphanumeric = false;
        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;
        int asciiSum = 0;
        int asciiTarget = 1000;

        Console.Clear();
        Console.Write("Please enter your string: ");
        userInput = Console.ReadLine();

        // All Checks
        foreach (char item in userInput)
        {
            isAlphanumeric = false;
            charValue = Convert.ToInt32(item);
            asciiSum += charValue;
            if (Enumerable.Range(65, 26).Contains(charValue))
            {
                isAlphanumeric = true;
                hasUppercase = true;
            }
            if (Enumerable.Range(97, 26).Contains(charValue))
            {
                isAlphanumeric = true;
                hasLowercase = true;
            }
            if (Enumerable.Range(48, 10).Contains(charValue))
            {
                isAlphanumeric = true;
                hasDigit = true;
            }
            if (isAlphanumeric == false)
            {
                break;
            }
            else
            {
                isAlphanumeric = true;
            }
        }

        // Print Result
        if (isAlphanumeric && hasDigit && hasLowercase && hasUppercase && asciiSum > asciiTarget)
        {
            Console.WriteLine("This string is secure.");
        }
        else
        {
            Console.WriteLine("This string is not secure.");
        }
    }
}