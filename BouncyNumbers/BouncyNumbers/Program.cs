internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;

        Console.Clear();
        Console.Write("Please enter your number: ");
        while (true)
        {
            userInput = Console.ReadLine().Trim();
            if (int.Parse(userInput) > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Try again, enter a larger number: ");
            }
        }
        if (IsIncreasingNumber(userInput) || IsDecreasingNumber(userInput))
        {
            Console.WriteLine($"{userInput} is not a bouncy number.");
        }
        else if (IsPerfectlyBouncy(userInput))
        {
            Console.WriteLine($"{userInput} is a perfectly bouncy number.");
        }
        else
        {
            Console.WriteLine($"{userInput} is a bouncy number.");
        }
    }

    private static bool IsIncreasingNumber(string num)
    {
        int previousDigit = 0;
        int currentDigit;
        foreach (char item in num)
        {
            currentDigit = int.Parse(num.ToString());
            if (currentDigit >= previousDigit)
            {
                previousDigit = currentDigit;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsDecreasingNumber(string num)
    {
        int previousDigit = 0;
        int currentDigit;
        foreach (char item in num)
        {
            currentDigit = int.Parse(num.ToString());
            if (currentDigit <= previousDigit)
            {
                previousDigit = currentDigit;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsPerfectlyBouncy(string num)
    {
        int followedByLarger = -1;
        int followedBySmaller = 0;
        int previousDigit = 0; 
        int currentDigit;
        foreach (char item in num)
        {
            currentDigit = int.Parse(item.ToString());
            if (currentDigit > previousDigit)
            {
                followedByLarger++;
            }
            else if (currentDigit < previousDigit)
            {
                followedBySmaller++;
            }
            previousDigit = currentDigit;
        }
        return followedByLarger == followedBySmaller;
    }
}