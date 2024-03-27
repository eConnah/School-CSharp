internal class Program
{
    private static void Main(string[] args)
    {
        //Delare and initilise variables
        int userInt;
        List<int> numbers = new();

        //Set variables
        userInt = GetInt("Please enter your number: ");
        while (true)
        {
            if (numbers.Contains(userInt))
            {
                break;
            }
            else
            {
                numbers.Add(userInt);
            }
            userInt = userInt * 3 + 1;
            if (userInt >= 100)
            {
                userInt = int.Parse(userInt.ToString()[1..]);      
            }
        }

        Console.WriteLine($"The list is {numbers.Count + 1} numbers long.");
    }

    private static int GetInt(string prompt)
    {
        Console.Clear();
        while(true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}