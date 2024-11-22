internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        int charValue;
        bool isEven;
        bool isEncoded = true;

        Console.Write("Please enter your string: ");
        userInput = Console.ReadLine();

        charValue = Convert.ToInt32(userInput[0]);
        isEven = charValue % 2 == 0;
        for (int i = 1; i < userInput.Length; i++)
        {
            charValue = Convert.ToInt32(userInput[i]);
            if(isEven == (charValue % 2 == 0))
            {
                isEncoded = false;
                break;
            }
            else
            {
                isEven = !isEven;
            }
        }

        if (isEncoded)
        {
            Console.WriteLine("This string is encoded.");   
        }
        else
        {
            Console.WriteLine("This string is not encoded.");
        }
    }
}